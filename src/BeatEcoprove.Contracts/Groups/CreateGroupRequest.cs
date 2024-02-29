using BeatEcoprove.Contracts.Authentication.SignIn;

using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Groups;

public record CreateGroupRequest
(
    IFormFile? AvatarPicture,
    string Name,
    string Description,
    bool IsPublic
) : IPictureRequest
{
    public Stream PictureStream => AvatarPicture?.OpenReadStream() ?? Stream.Null;
}