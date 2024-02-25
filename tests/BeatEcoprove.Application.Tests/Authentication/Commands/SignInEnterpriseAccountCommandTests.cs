using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;
using NSubstitute;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class SignInEnterpriseAccountCommandTests : BaseIntegrationTest
{
    private readonly IAccountService _accountService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;
    
    public SignInEnterpriseAccountCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _accountService = GetService<IAccountService>();
        _jwtProvider = GetService<IJwtProvider>();
        _unitOfWork = GetService<IUnitOfWork>();
        
        (SutAuth, SutProfile) = GetAuthUser();
    }

    private Auth SutAuth { get; }
    private Organization SutProfile { get; }
    
    private static async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

        return await response.Result.Content.ReadAsStreamAsync();
    }

    private static (Auth, Organization) GetAuthUser()
    {
        var auth = new Faker<Auth>()
            .CustomInstantiator(f =>
                Auth.Create(
                    Email.Create(f.Internet.Email()).Value,
                    Password.Create("Password12").Value))
            .Generate();

        var profile = new Faker<Organization>()
            .CustomInstantiator(f =>
                Organization.Create(
                    UserName.Create(f.Internet.UserName()).Value,
                    Phone.Create("+351", f.Phone.PhoneNumber("#########")).Value,
                    Address.Create(
                        f.Address.StreetName(),
                        12,
                        f.Address.City(),
                        PostalCode.Create(f.Address.ZipCode("####-###")).Value
                    ).Value
                    )
                )
            .Generate();
        
        auth.SetMainProfileId(profile.Id);
        profile.SetAuthPointer(auth.Id);

        return (auth, profile);
    }
    
    private SignInEnterpriseAccountCommand GetSutCommand(Stream avatarPicture)
    {
        // Arrange
        return new Faker<SignInEnterpriseAccountCommand>()
            .CustomInstantiator(f => new SignInEnterpriseAccountCommand(
                f.Person.FullName,
                TypeOption.Dryer.ToString(), 
                SutProfile.Phone.Value,
                SutProfile.Phone.Code,
                SutProfile.Address.Street,
                SutProfile.Address.Port,
                SutProfile.Address.Locality,
                SutProfile.Address.PostalCode.Value,
                SutProfile.UserName,
                avatarPicture,
                SutAuth.Email,
                SutAuth.Password))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_SignInPersonalAccount_WhenUserAlreadyExists()
    {
        var stream = await GetAvatarPicture();
        var handleEmailAlreadyExistsCommand = GetSutCommand(stream);
        
        var handleUsernameAlreadyExistsCommand = handleEmailAlreadyExistsCommand with
        {
            Email = new Faker<Email>()
                .CustomInstantiator(f => Email.Create(f.Internet.Email()).Value)
                .Generate()
        };

        await _accountService.CreateAccount(
            SutAuth.Email,
            SutAuth.Password,
            SutProfile,
            stream,
            default
        );

        await _unitOfWork.SaveChangesAsync();

        // Act
        var emailAlreadyExistsResult = 
            await Sender.Send(handleEmailAlreadyExistsCommand);
        
        var usernameAlreadyExistsResult = 
            await Sender.Send(handleUsernameAlreadyExistsCommand);

        // Assert
        Assert.True(emailAlreadyExistsResult.IsError);
        Assert.Equal(emailAlreadyExistsResult.FirstError.Code, Errors.User.EmailAlreadyExists.Code);
        
        Assert.True(usernameAlreadyExistsResult.IsError);
        Assert.Equal(usernameAlreadyExistsResult.FirstError.Code, Errors.User.UserNameAlreadyExists.Code);

    }

    [Fact]
    public async Task Should_ReturnAuthTokens_WhenUserSignInPersonalAccount()
    {
        var stream = await GetAvatarPicture();
        var command = GetSutCommand(stream);
    
        // Act
        var result = await Sender.Send(command);
    
        // Assert
        Assert.False(result.IsError);
        Assert.NotNull(result.Value);
    }
    
    [Fact]
    public async Task Should_ReturnValidAccessTokens_WhenUserSignInPersonalAccount()
    {
        var stream = await GetAvatarPicture();
        var command = GetSutCommand(stream);
    
        // Act
        var result = await Sender.Send(command);
    
        // Assert
        var accessToken = result.Value.AccessToken;
        var refreshToken = result.Value.RefreshToken;

        var isAccessTokenValid = await _jwtProvider.ValidateTokenAsync(accessToken);
        var isRefreshTokenValid = await _jwtProvider.ValidateTokenAsync(refreshToken);
        
        Assert.True(isAccessTokenValid);
        Assert.True(isRefreshTokenValid);
    }
}
