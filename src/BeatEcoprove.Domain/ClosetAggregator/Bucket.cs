using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.ClosetAggregator;

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

    public static ErrorOr<Bucket> Create(
        string name,
        List<ClothId> cloths)
    {
        Bucket bucket = new(
            BucketId.CreateUnique(), 
            name);

        if (cloths.Count == 0)
        {
            return Errors.Bucket.EmptyClothIds;
        }
        
        bucket.AddCloths(cloths);
        return bucket;
    }
    
    public void AddCloths(List<ClothId> cloths)
    {
        foreach (var cloth in cloths)
        {
            AddCloth(cloth);
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