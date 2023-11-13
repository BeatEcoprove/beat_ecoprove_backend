namespace BeatEcoprove.Contracts.Profile;

public record AddBucketToProfile
(
    string Name,
    List<Guid> ClothIds
);