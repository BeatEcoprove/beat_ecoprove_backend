namespace BeatEcoprove.Contracts.Closet.Bucket;

public record AddClothToBucketRequest
(
    List<Guid> ClothToAdd
);