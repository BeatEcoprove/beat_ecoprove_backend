using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application;

public record class ForgotPasswordCommand
(
    string Email
) : ICommand<ErrorOr<string>>;