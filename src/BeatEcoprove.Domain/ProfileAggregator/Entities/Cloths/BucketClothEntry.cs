using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class BucketClothEntry
{
    public BucketClothEntry(BucketId bucketId, ClothId clothId)
    {
        BucketId = bucketId;
        ClothId = clothId;
    }

    public BucketId BucketId { get; private set; }
    public ClothId ClothId { get; private set; }
}