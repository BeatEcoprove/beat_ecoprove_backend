using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Domain.ClosetAggregator;

namespace BeatEcoprove.Application.Shared.Helpers;

public class MixedClothBucketList
{
    public MixedClothBucketList(List<ClothResult> cloths, List<Bucket> buckets)
    {
        Cloths = cloths;
        Buckets = buckets;
    }

    public List<ClothResult> Cloths { get; set; }
    public List<Bucket> Buckets { get; set; }
}