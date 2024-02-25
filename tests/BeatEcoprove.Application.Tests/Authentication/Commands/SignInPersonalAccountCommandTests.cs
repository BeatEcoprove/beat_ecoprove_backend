using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class SignInPersonalAccountCommandTests : BaseIntegrationTest
{
    private readonly IAccountService _accountService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;
    
    public SignInPersonalAccountCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _accountService = GetService<IAccountService>();
        _jwtProvider = GetService<IJwtProvider>();
        _unitOfWork = GetService<IUnitOfWork>();

        (SutAuth, SutProfile) = GetAuthUser();
    }

    private Auth SutAuth { get; }
    private Consumer SutProfile { get; }
    
    private static async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

       return await response.Result.Content.ReadAsStreamAsync();
    }

    private static (Auth, Consumer) GetAuthUser()
    {
        var auth = new Faker<Auth>()
            .CustomInstantiator(f =>
                Auth.Create(
                    Email.Create(f.Internet.Email()).Value,
                    Password.Create("Password12").Value))
            .Generate();

        var profile = new Faker<Consumer>()
            .CustomInstantiator(f =>
                Consumer.Create(
                    UserName.Create(f.Internet.UserName()).Value,
                    Phone.Create("+351", f.Phone.PhoneNumber("#########")).Value,
                    DateOnly.FromDateTime(f.Person.DateOfBirth),
                    Gender.Male))
            .Generate();
        
       auth.SetMainProfileId(profile.Id);
       profile.SetAuthPointer(auth.Id);

       return (auth, profile);
    }
    
    private SignInPersonalAccountCommand GetSutCommand(Stream avatarPicture)
    {
        // Arrange
        return new Faker<SignInPersonalAccountCommand>()
            .CustomInstantiator(f => new SignInPersonalAccountCommand(
                f.Person.FullName,
                SutProfile.BornDate, 
                SutProfile.UserName,
                SutProfile.Gender.ToString(),
                SutProfile.Phone.Code,
                SutProfile.Phone.Value,
                avatarPicture,
                SutAuth.Email,
                SutAuth.Password))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_SignInPersonalAccount_WhenUserAlreadyExists()
    {
        // Arrange
        var stream = await GetAvatarPicture();
        var handleEmailAreadyExistsCommand = GetSutCommand(stream);
        
        var handleUsernameAlreadyExistsCommand = handleEmailAreadyExistsCommand with
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
        var emailAreadyExistsResult = 
            await Sender.Send(handleEmailAreadyExistsCommand);
        
        var usernameAreadyExistsResult = 
            await Sender.Send(handleUsernameAlreadyExistsCommand);

        // Assert
        Assert.True(emailAreadyExistsResult.IsError);
        Assert.Equal(emailAreadyExistsResult.FirstError.Code, Errors.User.EmailAlreadyExists.Code);
        
        Assert.True(usernameAreadyExistsResult.IsError);
        Assert.Equal(usernameAreadyExistsResult.FirstError.Code, Errors.User.UserNameAlreadyExists.Code);
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

        var isAccessTokenValid = await _jwtProvider.ValidateToken(accessToken);
        var isRefreshTokenValid = await _jwtProvider.ValidateToken(refreshToken);
        
        Assert.True(isAccessTokenValid);
        Assert.True(isRefreshTokenValid);
    }
}
