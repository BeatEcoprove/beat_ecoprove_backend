using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Queries;

public class LoginQueryTests : BaseIntegrationTest
{
    private readonly IAccountService _accountService;
    private readonly IUnitOfWork _unitOfWork;
    private const string SutPassword = "Password12";

    public LoginQueryTests(IntegrationWebApplicationFactory factory)
        : base(factory)
    {
        _accountService = GetService<IAccountService>();
        _unitOfWork = GetService<IUnitOfWork>();
    }
    
    private static LoginQuery GetSutQuery()
    {
        // Arrange
        return new Faker<LoginQuery>()
            .CustomInstantiator(f => new LoginQuery(
                f.Internet.Email(),
                SutPassword))
            .Generate();
    }
    
    private static async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

        return await response.Result.Content.ReadAsStreamAsync();
    }

    private async Task CreateUserAccount(
        string email,
        string password = SutPassword,
        CancellationToken cancellationToken = default)
    {
        var avatarPicture = await GetAvatarPicture();
        var auth = new Faker<Auth>()
            .CustomInstantiator(f =>
                Auth.Create(
                    Email.Create(email).Value,
                    Password.Create(password).Value))
            .Generate();
        
        var profile = new Faker<Consumer>()
            .CustomInstantiator(f =>
                Consumer.Create(
                    UserName.Create(f.Internet.UserName()).Value,
                    Phone.Create("+351", f.Phone.PhoneNumber("#########")).Value,
                    DateOnly.FromDateTime(f.Person.DateOfBirth),
                    Gender.Male))
            .Generate();
        
        await _accountService.CreateAccount(
            auth.Email,
            auth.Password,
            profile,
            avatarPicture,
            cancellationToken);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
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
        await CreateUserAccount(query.Email, "Password123");
    
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
        await CreateUserAccount(query.Email);
    
        // Act
        var result = await Sender.Send(query, default);
    
        // Assert
        Assert.False(result.IsError);
        Assert.NotNull(result.Value.AccessToken);
        Assert.NotNull(result.Value.RefreshToken);
    }
}
