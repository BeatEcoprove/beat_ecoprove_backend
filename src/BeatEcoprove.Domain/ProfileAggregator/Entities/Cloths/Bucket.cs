using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class Bucket : Entity<BucketId>
{
    private readonly List<Cloth> _cloths = new();
    
    public Bucket(
        BucketId id,
        string name)
    {
        Id = id;
        Name = name;
    }

    public string Name { get; private set; }
    public IReadOnlyList<Cloth> Cloths => _cloths.AsReadOnly();

    public static Bucket Create(
        List<Cloth> cloths,
        string name)
    {
        Bucket bucket = new(
            BucketId.CreateUnique(), 
            name);
        
        bucket.AddGarments(cloths);
        return bucket;
    }
    
    public void AddGarments(List<Cloth> cloths)
    {
        _cloths.AddRange(cloths);
    }
}