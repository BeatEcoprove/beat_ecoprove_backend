using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public record MessageResponse
(
    Guid GroupId,
    ProfileResponse Sender,
    string Content,
    DateTime CreatedAt
);