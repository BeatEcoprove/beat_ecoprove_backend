namespace BeatEcoprove.Contracts.Authentication.SignIn;

public record SignInEnterpriseAccountRequest
(
    string Name,
    string TypeOption,
    string Phone,
    string CountryCode,
    string Address,
    string UserName,
    string AvatarUrl,
    string Email,
    string Password,
    string PostalCode
);