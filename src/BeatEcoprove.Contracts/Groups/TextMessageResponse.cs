using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public record TextMessageResponse
(
    Guid GroupId,
    ProfileResponse Sender,
    string Content,
    DateTimeOffset CreatedAt
);