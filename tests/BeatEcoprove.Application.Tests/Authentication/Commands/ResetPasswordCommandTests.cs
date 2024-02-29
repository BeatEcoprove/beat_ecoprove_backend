using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Authentication.Commands.ResetPassword;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class ResetPasswordCommandTests : AuthenticationBaseTests
{
    private readonly string _code;
    private readonly string _forgotToken;
    private readonly Email _userEmail;
    
    private readonly IJwtProvider _jwtProvider;
    private readonly IKeyValueRepository<string> _keyValueRepository;
    private readonly IAuthRepository _authRepository;
    private readonly IPasswordProvider _passwordProvider;
    
    public ResetPasswordCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _jwtProvider = GetService<IJwtProvider>();
        _keyValueRepository = GetService<IKeyValueRepository<string>>();
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
    
    private static ResetPasswordCommand GetSutCommand(string code = "")
    {
        // Arrange
        return new Faker<ResetPasswordCommand>()
            .CustomInstantiator(f => new ResetPasswordCommand(
                NewDefaultPassword,
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
        await CreateUserAccount<Consumer>(_userEmail);
        
        var forgotKey = new ForgotKey(_code);
        await _keyValueRepository.AddAsync(forgotKey, _forgotToken, ForgotPasswordCommandHandler.ForgotCodeTimeSpan);

        // Act
        var result = await Sender.Send(command);

        // Assert
        Assert.False(result.IsError);
        
        var auth = await _authRepository.GetAuthByEmail(_userEmail, default);
        var validatePassword = _passwordProvider.VerifyPassword(
            DefaultPassword, 
            auth!.Password);
        
        Assert.True(validatePassword);
    }
}
