using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class SignInEnterpriseAccountCommandTests : AuthenticationBaseTests
{
    private readonly IJwtProvider _jwtProvider;
    
    public SignInEnterpriseAccountCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _jwtProvider = GetService<IJwtProvider>();
        
    }

    private SignInEnterpriseAccountCommand GetSutCommand(Stream avatarPicture)
    {
        var (auth, organization) = GetAuth<Organization>();
        
        // Arrange
        return new Faker<SignInEnterpriseAccountCommand>()
            .CustomInstantiator(f => new SignInEnterpriseAccountCommand(
                f.Person.FullName,
                TypeOption.Dryer.ToString(), 
                organization.Phone.Value,
                organization.Phone.Code,
                organization.Address.Street,
                organization.Address.Port,
                organization.Address.Locality,
                organization.Address.PostalCode.Value,
                organization.UserName,
                avatarPicture,
                auth.Email,
                auth.Password))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_SignInEnterpriseAccount_WhenUserAlreadyExists()
    {
        var stream = await GetAvatarPicture();
        var handleEmailAlreadyExistsCommand = GetSutCommand(stream);
        
        var handleUsernameAlreadyExistsCommand = handleEmailAlreadyExistsCommand with
        {
            Email = new Faker<Email>()
                .CustomInstantiator(f => Email.Create(f.Internet.Email()).Value)
                .Generate()
        };

        await CreateUserAccount<Organization>(
                email: handleEmailAlreadyExistsCommand.Email, 
                username: handleEmailAlreadyExistsCommand.UserName);

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
