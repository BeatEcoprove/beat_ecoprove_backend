using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class BucketEntry
{
    public BucketEntry(
        ProfileId profileId, 
        BucketId bucket)
    {
        ProfileId = profileId;
        Bucket = bucket;
        IsBlocked = false;
    }

    public ProfileId ProfileId { get; private set; }
    public BucketId Bucket { get; private set; }
    public bool IsBlocked { get; private set; }
}