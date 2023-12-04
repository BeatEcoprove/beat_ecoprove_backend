using BeatEcoprove.Contracts.Closet.Cloth;

namespace BeatEcoprove.Contracts.Closet.Bucket;

public record BucketResponse
(
    Guid Id,
    string Name,
    List<ClothResponse> AssociatedCloth
);