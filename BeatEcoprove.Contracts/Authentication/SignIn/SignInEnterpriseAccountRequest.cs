namespace BeatEcoprove.Contracts.Authentication.SignIn;

public record SignInEnterpriseAccountRequest
(
    string Name,
    string TypeOption,
    string Phone,
    string CountryCode,
    string Street,
    int Port,
    string Locality,
    string PostalCode,
    string UserName,
    string AvatarUrl,
    string Email,
    string Password
);