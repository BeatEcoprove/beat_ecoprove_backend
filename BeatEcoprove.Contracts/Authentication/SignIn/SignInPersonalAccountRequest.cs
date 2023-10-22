namespace BeatEcoprove.Contracts.Authentication.SignIn;

public record SignInPersonalAccountRequest
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
);