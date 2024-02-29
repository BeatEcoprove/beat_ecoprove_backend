using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class BucketEntry
{
    public BucketEntry(
        ProfileId profileId,
        BucketId bucketId)
    {
        ProfileId = profileId;
        BucketId = bucketId;
        IsBlocked = false;
    }

    public ProfileId ProfileId { get; private set; }
    public BucketId BucketId { get; private set; }
    public bool IsBlocked { get; private set; }
    public DateTimeOffset? DeletedAt { get; set; }
}