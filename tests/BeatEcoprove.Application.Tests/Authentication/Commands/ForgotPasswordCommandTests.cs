using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;
using ErrorOr;
using NSubstitute;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class ForgotPasswordCommandTests
{
    private readonly IJwtProvider _jwtProvider = Substitute.For<IJwtProvider>();
    private readonly IAuthRepository _authRepository = Substitute.For<IAuthRepository>();
    private readonly IMailSender _mailSender = Substitute.For<IMailSender>();

    private readonly ForgotPasswordCommandHandler _sut;

    public ForgotPasswordCommandTests()
    {
        _sut = new ForgotPasswordCommandHandler(
            _jwtProvider,
            _authRepository,
            _mailSender
        );
    }

    private ForgotPasswordCommand GetSutCommand()
    {
        // Arrange
        return new Faker<ForgotPasswordCommand>()
            .CustomInstantiator(f => new ForgotPasswordCommand(
                f.Internet.Email()))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_SendForgotEmail_WhenUserNotExists()
    {
        // Arrange
        Email email;

        var command = GetSutCommand();

        email = Email.Create(command.Email).Value;

        _authRepository.GetAuthByEmail(
            email, default)
            .Returns(null as Auth);

        // Act
        var result = await _sut.Handle(command, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }
}
