using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;

public record SignInPersonalAccountCommand
(
    string Name,
    DateOnly BornDate,
    string UserName,
    string Gender,
    string CountryCode,
    string Phone,
    Stream AvatarPicture,
    string Email,
    string Password
) : ICommand<ErrorOr<AuthenticationResult>>;