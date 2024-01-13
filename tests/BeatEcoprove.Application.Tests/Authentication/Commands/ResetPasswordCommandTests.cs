using BeatEcoprove.Application.Authentication.Commands.ResetPassword;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;
using NSubstitute;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class ResetPasswordCommandTests
{
    private const string CustomForgotToken = "custom_forgot_token";

    private readonly IJwtProvider _jwtProvider = Substitute.For<IJwtProvider>();
    private readonly IAuthRepository _authRepository = Substitute.For<IAuthRepository>();
    private readonly IPasswordProvider _passwordProvider = Substitute.For<IPasswordProvider>();

    private readonly ResetPasswordCommandHandler _sut;

    public ResetPasswordCommandTests()
    {
        _sut = new ResetPasswordCommandHandler(
            _jwtProvider,
            _authRepository,
            _passwordProvider
        );
    }

    private ResetPasswordCommand GetSutCommand(string token)
    {
        // Arrange
        return new Faker<ResetPasswordCommand>()
            .CustomInstantiator(f => new ResetPasswordCommand(
                f.Internet.Password(),
                token))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_ResetPassword_ForgotTokenIsNotValid()
    {
        // Arrange
        var command = GetSutCommand("not_valid_token");

        _jwtProvider.ValidateToken(
            command.ForgotToken).Returns(false);

        // Act
        var result = await _sut.Handle(command, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.ForgotPassword.ForgotTokenNotValid.Code);
    }

    private Auth GetAuth(string fakeEmail)
    {
        Email email = Email.Create(fakeEmail).Value;
        var password = Password.Create("Password12").Value;

        return Auth.Create(email, password);
    }

    [Fact]
    public async Task ShouldNot_ResetPassword_WhenUserDoesNotExists()
    {
        Auth auth = GetAuth("fake@email.com");

        // Arrange
        var command = GetSutCommand(CustomForgotToken);

        _jwtProvider.ValidateToken(
            command.ForgotToken).Returns(true);

        _jwtProvider.GetClaims(
            command.ForgotToken).Returns(new Dictionary<string, string>
            {
                { UserClaims.Email, auth.Email.Value }
            });

        _authRepository
            .GetAuthByEmail(auth.Email, default)
            .Returns(null as Auth);

        // Act
        var result = await _sut.Handle(command, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }
}
