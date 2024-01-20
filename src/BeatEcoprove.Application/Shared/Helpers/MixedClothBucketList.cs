using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;

namespace BeatEcoprove.Application.Shared.Helpers;

public class MixedClothBucketList
{
    public MixedClothBucketList(
        List<ClothResultExtension> cloths, 
        List<Bucket> buckets
    )
    {
        Cloths = cloths;
        Buckets = buckets;
    }

    public List<ClothResultExtension> Cloths { get; set; }
    public List<Bucket> Buckets { get; set; }
}