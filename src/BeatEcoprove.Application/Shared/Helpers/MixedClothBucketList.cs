using BeatEcoprove.Domain.ClothAggregator;

namespace BeatEcoprove.Application.Shared.Helpers;

public class MixedClothBucketList
{
    public MixedClothBucketList(List<Cloth> cloths, List<Bucket> buckets)
    {
        Cloths = cloths;
        Buckets = buckets;
    }

    public List<Cloth> Cloths { get; set; }
    public List<Bucket> Buckets { get; set; }
}