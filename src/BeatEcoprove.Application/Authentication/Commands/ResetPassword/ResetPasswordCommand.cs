using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application;

public record ResetPasswordCommand
(
    string Password,
    string ForgotToken
) : ICommand<ErrorOr<string>>;