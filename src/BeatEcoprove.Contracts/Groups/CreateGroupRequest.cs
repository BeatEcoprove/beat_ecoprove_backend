using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Groups;

public record CreateGroupRequest
(
    IFormFile AvatarPicture,
    string Name,
    string Description,
    bool IsPublic
);