using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Queries;

public class LoginQueryTests : AuthenticationBaseTests
{
    public LoginQueryTests(
        IntegrationWebApplicationFactory factory)
        : base(factory)
    {
    }
    
    private static LoginQuery GetSutQuery()
    {
        // Arrange
        return new Faker<LoginQuery>()
            .CustomInstantiator(f => new LoginQuery(
                f.Internet.Email(),
                DefaultPassword))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_Login_UserDoesNotExists()
    {
        // Arrange
        var query = GetSutQuery();

        // Act
        var result = 
            await Sender.Send(query, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }
    
    [Fact]
    public async Task ShouldNot_Login_IncorrectCredentials()
    {
        // Arrange
        var query = GetSutQuery();
        await CreateUserAccount<Consumer>(
            email: query.Email,
            password: NewDefaultPassword);
    
        // Act
        var result = await Sender.Send(query, default);
    
        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.BadCredentials.Code);
    }
    
    [Fact]
    public async Task Should_GenerateTokens_WhenLoginCorrectly()
    {
        // Arrange
        var query = GetSutQuery();
        await CreateUserAccount<Consumer>(query.Email);
    
        // Act
        var result = await Sender.Send(query, default);
    
        // Assert
        Assert.False(result.IsError);
        Assert.NotNull(result.Value.AccessToken);
        Assert.NotNull(result.Value.RefreshToken);
    }
}
