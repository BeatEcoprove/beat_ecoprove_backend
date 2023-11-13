using BeatEcoprove.Contracts.Closet.Cloth;

namespace BeatEcoprove.Contracts.Closet.Bucket;

public record BucketResponse
(
    string Name,
    List<ClothResponse> AssociatedCloth
);