using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Store;

public record RatingResponse
(
    Guid StoreId,
    double Rating,
    ProfileClosetResponse Owner
);