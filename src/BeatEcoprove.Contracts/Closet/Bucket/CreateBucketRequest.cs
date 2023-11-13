namespace BeatEcoprove.Contracts.Closet.Bucket;

public record CreateBucketRequest
(
    string Name,
    List<Guid> ClothIds
);