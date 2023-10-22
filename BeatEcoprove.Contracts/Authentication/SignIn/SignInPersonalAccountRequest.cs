namespace BeatEcoprove.Contracts.Authentication.SignIn;

public record SignInPersonalAccountRequest
(
    string Name,
    DateOnly BornDate,
    string Gender,
    string Phone,
    string UserName,
    string AvatarUrl,
    string Email,
    string Password
);