using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;

namespace BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;

public record SignInPersonalAccountCommand
(
    string Name,
    DateOnly BornDate,
    string UserName,
    string Gender,
    string CountryCode,
    string Phone,
    string AvatarUrl,
    string Email,
    string Password,
    int Xp,
    double SustainabilityPoints,
    double EcoScore
) : ICommand<AuthenticationResult>;