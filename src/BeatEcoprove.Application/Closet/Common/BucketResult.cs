using BeatEcoprove.Domain.ClosetAggregator;

namespace BeatEcoprove.Application.Closet.Common;

public record BucketResult
(
    Bucket Bucket,
    List<ClothResult> Cloths
);