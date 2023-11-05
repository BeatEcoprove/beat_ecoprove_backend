using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.ResetPassword;

public record ResetPasswordCommand
(
    string Password,
    string ForgotToken
) : ICommand<ErrorOr<string>>;