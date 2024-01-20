using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Authentication.SignIn;

public record SignInEnterpriseAccountRequest(
    string Name,
    string TypeOption,
    string Phone,
    string CountryCode,
    string Street,
    int Port,
    string Locality,
    string PostalCode,
    string UserName,
    IFormFile? AvatarPicture,
    string Email,
    string Password
) : IPictureRequest
{
    public Stream PictureStream => AvatarPicture != null ? AvatarPicture.OpenReadStream() : Stream.Null;
};