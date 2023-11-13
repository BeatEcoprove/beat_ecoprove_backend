namespace BeatEcoprove.Contracts.Profile;

public record ClosetResponse
(
    List<ClothResponse> Cloths,
    List<BucketResponse> Buckets);