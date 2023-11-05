using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class ClothBucketEntry
{
    private ClothBucketEntry() { }
    
    private ClothBucketEntry(
        ProfileId profile, 
        ClothId cloth)
    {
        Profile = profile;
        Cloth = cloth;
    }
    
    private ClothBucketEntry(
        ProfileId profile, 
        ClothId cloth, 
        BucketId bucket)
    {
        Profile = profile;
        Cloth = cloth;  
        Bucket = bucket;
    }

    public ProfileId Profile { get; private set; } = null!;
    public ClothId Cloth { get; private set; } = null!;
    public BucketId Bucket { get; private set; } = null!;
    public bool IsBlocked { get; private set; } = false;

    public static ClothBucketEntry AddClothEntry(ProfileId profile, ClothId cloth)
    {
        return new(
            profile,
            cloth);
    }
    
    public static ClothBucketEntry AddBucketEntry(ProfileId profile, ClothId cloth, BucketId bucket)
    {
        return new(
            profile,
            cloth,
            bucket);
    }
}