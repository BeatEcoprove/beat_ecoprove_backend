using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClothAggregator;

public class Bucket : AggregateRoot<BucketId, Guid>
{
    private readonly List<BucketClothEntry> _bucketClothEntries = new();
    
    public Bucket(
        BucketId id,
        string name)
    {
        Id = id;
        Name = name;
    }

    public string Name { get; private set; }
    public IReadOnlyList<BucketClothEntry> BucketClothEntries => _bucketClothEntries.AsReadOnly();

    public static Bucket Create(
        List<Cloth> cloths,
        string name)
    {
        Bucket bucket = new(
            BucketId.CreateUnique(), 
            name);
        
        bucket.AddCloths(cloths);
        return bucket;
    }
    
    public void AddCloths(List<Cloth> cloths)
    {
        foreach (var cloth in cloths)
        {
            AddCloth(cloth.Id);
        }
    }
    
    public void AddCloth(ClothId clothId)
    {
        _bucketClothEntries.Add(
            new BucketClothEntry(
                    this.Id,
                    clothId
                ));
    }
}