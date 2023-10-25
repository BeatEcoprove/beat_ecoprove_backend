using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Authentication.SignIn;

public record SignInPersonalAccountRequest
(
    string Name,
    DateOnly BornDate,
    string UserName,
    string Gender,
    string CountryCode,
    string Phone,
    IFormFile AvatarPicture,
    string Email,
    string Password
);