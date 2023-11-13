using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;

namespace BeatEcoprove.Contracts.Closet;

public record ClosetResponse
(
    List<ClothResponse> Cloths,
    List<BucketResponse> Buckets);