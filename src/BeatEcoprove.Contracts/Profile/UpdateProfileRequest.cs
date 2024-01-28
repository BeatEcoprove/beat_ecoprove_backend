using BeatEcoprove.Contracts.Authentication.SignIn;
using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Profile;

public record UpdateProfileRequest
(
    string? Username,
    string? Email,
    IFormFile? AvatarPicture,
    string? Phone,
    string? PhoneCode
) : IPictureRequest
{
    public Stream PictureStream => AvatarPicture?.OpenReadStream() ?? Stream.Null;
}