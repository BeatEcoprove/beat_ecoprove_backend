namespace BeatEcoprove.Contracts.Closet.Bucket;

public record RemoveClothFromBucketRequest
(
    List<Guid> ClothToRemove
);