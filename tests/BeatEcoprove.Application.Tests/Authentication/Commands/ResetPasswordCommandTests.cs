using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Authentication.Commands.ResetPassword;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class ResetPasswordCommandTests : BaseIntegrationTest
{
    private readonly string _code;
    private readonly string _forgotToken;
    private readonly Email _userEmail;
    
    private readonly IJwtProvider _jwtProvider;
    private readonly IKeyValueRepository<string> _keyValueRepository;
    private readonly IAccountService _accountService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAuthRepository _authRepository;
    private readonly IPasswordProvider _passwordProvider;
    
    public ResetPasswordCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _jwtProvider = GetService<IJwtProvider>();
        _keyValueRepository = GetService<IKeyValueRepository<string>>();
        _accountService = GetService<IAccountService>();
        _unitOfWork = GetService<IUnitOfWork>();
        _authRepository = GetService<IAuthRepository>();
        _passwordProvider = GetService<IPasswordProvider>();
        
        _userEmail = new Faker<Email>()
            .CustomInstantiator(f => Email.Create(f.Internet.Email()).Value)
            .Generate();
        
        _forgotToken = FakeForgotToken();
        _code = _jwtProvider.GenerateRandomCode(ForgotPasswordCommandHandler.ForgotCodeLength);
    }

    private string FakeForgotToken()
    {
        return new Faker<string>()
            .CustomInstantiator(f =>
                _jwtProvider.GenerateToken(
                    new ForgotTokenPayload(
                        _userEmail.Value,
                        DateTime.UtcNow.AddDays(3))));
    }
    
    private static async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

        return await response.Result.Content.ReadAsStreamAsync();
    }
    
    private async Task CreateUserAccount(
        string email,
        CancellationToken cancellationToken = default)
    {
        var avatarPicture = await GetAvatarPicture();
        var auth = new Faker<Auth>()
            .CustomInstantiator(f =>
                Auth.Create(
                    Email.Create(email).Value,
                    Password.Create("Password123").Value))
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
    
    private static ResetPasswordCommand GetSutCommand(string code = "")
    {
        // Arrange
        return new Faker<ResetPasswordCommand>()
            .CustomInstantiator(f => new ResetPasswordCommand(
                "NewPassword12",
                code))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_ResetPassword_ForgotTokenIsNotValid()
    {
        // Arrange
        var command = GetSutCommand(_code);
        
        var forgotKey = new ForgotKey(_code);
        await _keyValueRepository.AddAsync(forgotKey, string.Empty, ForgotPasswordCommandHandler.ForgotCodeTimeSpan);

        // Act
        var result = await Sender.Send(command);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.ForgotPassword.ForgotTokenNotValid.Code);
    }

    [Fact]
    public async Task ShouldNot_ResetPassword_WhenUserDoesNotExists()
    {
        // Arrange
        var command = GetSutCommand(_code);
        
        var forgotKey = new ForgotKey(_code);
        await _keyValueRepository.AddAsync(forgotKey, _forgotToken, ForgotPasswordCommandHandler.ForgotCodeTimeSpan);

        // Act
        var result = await Sender.Send(command);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }
    
    [Fact]
    public async Task ShouldNot_ResetPassword_IfCodeDoesNotExists()
    {
        // Arrange
        var command = GetSutCommand(_code);
        
        var forgotKey = new ForgotKey(_code);
        await _keyValueRepository.AddAsync(forgotKey, _forgotToken, ForgotPasswordCommandHandler.ForgotCodeTimeSpan);

        // Act
        var result = await Sender.Send(command);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }
    
    [Fact]
    public async Task Should_ResetPassword()
    {
        // Arrange
        var command = GetSutCommand(_code);
        await CreateUserAccount(_userEmail);
        
        var forgotKey = new ForgotKey(_code);
        await _keyValueRepository.AddAsync(forgotKey, _forgotToken, ForgotPasswordCommandHandler.ForgotCodeTimeSpan);

        // Act
        var result = await Sender.Send(command);

        // Assert
        Assert.False(result.IsError);
        
        var auth = await _authRepository.GetAuthByEmail(_userEmail, default);
        var validatePassword = _passwordProvider.VerifyPassword(
            "Password123", 
            auth!.Password);
        
        Assert.True(validatePassword);
    }
}
