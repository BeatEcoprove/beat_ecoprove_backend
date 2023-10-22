using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;

namespace BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;

public record SignInPersonalAccountCommand
(
    string Name,
    DateOnly BornDate,
    string Gender,
    string Phone,
    string UserName,
    string AvatarUrl,
    string Email,
    string Password
) : ICommand<AuthenticationResult>;