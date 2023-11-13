namespace BeatEcoprove.Contracts.Profile;

public record BucketResponse
(
    string Name,
    List<Guid> AssociatedClothIds
);