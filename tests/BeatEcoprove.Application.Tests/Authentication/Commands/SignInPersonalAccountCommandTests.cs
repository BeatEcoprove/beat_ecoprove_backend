using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class SignInPersonalAccountCommandTests : AuthenticationBaseTests
{
    private readonly IJwtProvider _jwtProvider;
    
    public SignInPersonalAccountCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _jwtProvider = GetService<IJwtProvider>();
    }

    private SignInPersonalAccountCommand GetSutCommand(Stream avatarPicture)
    {
        var (auth, profile) = GetAuth<Consumer>();
        
        // Arrange
        return new Faker<SignInPersonalAccountCommand>()
            .CustomInstantiator(f => new SignInPersonalAccountCommand(
                f.Person.FullName,
                profile.BornDate, 
                profile.UserName,
                profile.Gender.ToString(),
                profile.Phone.Code,
                profile.Phone.Value,
                avatarPicture,
                auth.Email,
                auth.Password))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_SignInPersonalAccount_WhenUserAlreadyExists()
    {
        // Arrange
        var stream = await GetAvatarPicture();
        var handleEmailAlreadyExistsCommand = GetSutCommand(stream);
        
        var handleUsernameAlreadyExistsCommand = handleEmailAlreadyExistsCommand with
        {
            Email = new Faker<Email>()
                .CustomInstantiator(f => Email.Create(f.Internet.Email()).Value)
                .Generate()
        };

        await CreateUserAccount<Consumer>(
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
