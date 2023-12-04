namespace BeatEcoprove.Contracts.Closet.Bucket;

public record AddClothsToBucketRequest
(
    List<Guid> ClothToAdd
);