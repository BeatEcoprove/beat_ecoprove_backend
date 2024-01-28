using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.FeedBacks;

public record FeedBackResponse
(
    Guid Id,
    ProfileResponse Sender,
    string Title,
    string Description
);