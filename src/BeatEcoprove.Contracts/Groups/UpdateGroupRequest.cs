using BeatEcoprove.Contracts.Authentication.SignIn;

using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Groups;

public record UpdateGroupRequest
(
    string? Name,
    string? Description,
    bool? IsPublic,
    IFormFile? AvatarPicture
) : IPictureRequest
{
    public Stream PictureStream => AvatarPicture?.OpenReadStream() ?? Stream.Null;
}