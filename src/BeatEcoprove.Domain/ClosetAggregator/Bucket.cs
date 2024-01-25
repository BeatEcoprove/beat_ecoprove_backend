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
    public int ClothNumber => _bucketClothEntries.Count(entry => entry.DeletedAt == null);
    public IReadOnlyList<BucketClothEntry> BucketClothEntries => _bucketClothEntries
        .AsReadOnly()
        .Where(clothEntry => clothEntry.DeletedAt == null)
        .ToList();

    public static ErrorOr<Bucket> Create(
        string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Errors.Bucket.InvalidBucketName;
        }
        
        return new Bucket(
            BucketId.CreateUnique(),
            name);
    }

    private static bool CheckIfClothAreDiferent(List<ClothId> cloths)
    {
        return cloths.Select(cloth => cloth).Distinct().Count() == cloths.Count;
    }

    private static bool HasZeroCloth(List<ClothId> cloths)
    {
        return cloths.Count == 0;
    }

    public ErrorOr<bool> AddCloths(List<ClothId> cloths)
    {
        var alreadyDeletedCloth = _bucketClothEntries
            .Where(entry => cloths.Contains(entry.ClothId) && entry.DeletedAt != null)
            .ToList();

        if (HasZeroCloth(cloths))
        {
            return Errors.Bucket.EmptyClothIds;
        }

        if (!CheckIfClothAreDiferent(cloths))
        {
            return Errors.Bucket.ClothAreNotUnique;
        }
        
        foreach (var cloth in cloths)
        {
            if (_bucketClothEntries.Any(entry => entry.ClothId == cloth && entry.DeletedAt == null))
            {
                return Errors.Bucket.CanAddClothToBucket;
            }
            
            if (alreadyDeletedCloth.Any(entry => entry.ClothId == cloth))
            {
                _bucketClothEntries.First(entry => entry.ClothId == cloth).DeletedAt = null;
                continue;
            }
            
            AddCloth(cloth);
        }

        return true;
    }
    
    public void AddCloth(ClothId clothId)
    {
        _bucketClothEntries.Add(
            new BucketClothEntry(
                    this.Id,
                    clothId
                ));
    }

    public ErrorOr<bool> RemoveCloths(List<ClothId> clothToRemove)
    {
        if (HasZeroCloth(clothToRemove))
        {
            return Errors.Bucket.EmptyClothIds;
        }

        if (!CheckIfClothAreDiferent(clothToRemove))
        {
            return Errors.Bucket.ClothAreNotUnique;
        }
        
        _bucketClothEntries
            .RemoveAll(entry => 
                clothToRemove.Contains(entry.ClothId));

        return true;
    }
    
    public void SetName(string name)
    {
        Name = name;
    }
}