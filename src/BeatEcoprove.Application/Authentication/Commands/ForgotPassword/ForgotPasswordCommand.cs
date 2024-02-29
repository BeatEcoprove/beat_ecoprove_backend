using BeatEcoprove.Application.Shared;

using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.ForgotPassword;

public record class ForgotPasswordCommand
(
    string Email
) : ICommand<ErrorOr<string>>;