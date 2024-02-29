using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Events;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;

using ErrorOr;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

public abstract class Profile : AggregateRoot<ProfileId, Guid>
{
    private const int ConvertConcurrencyRange = 10;
    private readonly List<ClothEntry> _clothEntries = new();
    private readonly List<BucketEntry> _bucketEntries = new();

    protected Profile()
    {
    }

    protected Profile(
        UserName userName,
        Phone phone,
        double xP,
        int sustainabilityPoints,
        int ecoScore,
        UserType type)
    {
        Id = ProfileId.CreateUnique();
        UserName = userName;
        Phone = phone;
        XP = xP;
        SustainabilityPoints = sustainabilityPoints;
        EcoScore = ecoScore;
        Type = type;
        Level = 0;
        EcoCoins = 0;
    }

    public AuthId AuthId { get; protected set; } = null!;
    public UserName UserName { get; protected set; } = null!;
    public Phone Phone { get; protected set; } = null!;
    public double XP { get; set; }
    public int Level { get; set; }
    public int EcoCoins { get; protected set; }
    public int SustainabilityPoints { get; set; }
    public int EcoScore { get; set; }
    public string AvatarUrl { get; protected set; } = null!;
    public UserType Type { get; protected set; } = null!;
    public IReadOnlyList<ClothEntry> ClothEntries => _clothEntries.AsReadOnly();
    public IReadOnlyList<BucketEntry> BucketEntries => _bucketEntries.AsReadOnly();

    public void SetProfileAvatar(string avatarUrl)
    {
        AvatarUrl = avatarUrl;
    }

    public void SetAuthPointer(AuthId authId)
    {
        ArgumentNullException.ThrowIfNull(authId);
        AuthId = authId;
    }

    public void AddCloth(Cloth cloth)
    {
        _clothEntries.Add(
            new ClothEntry(this.Id, cloth.Id));

        this.AddDomainEvent(new CreateClothDomainEvent(this, cloth));
    }

    public void AddBucket(Bucket bucket)
    {
        _bucketEntries.Add(
            new BucketEntry(this.Id, bucket.Id));
    }

    public ErrorOr<bool> RemoveCloth(ClothId clothId)
    {
        var clothEntry = _clothEntries
            .SingleOrDefault(clothEntry => clothEntry.ClothId == clothId);

        if (clothEntry is null)
        {
            return Errors.Profile.CannotFindCloth;
        }

        return _clothEntries.Remove(clothEntry);
    }

    public ErrorOr<bool> RemoveBucket(BucketId bucketId)
    {
        var bucketEntry = _bucketEntries
            .SingleOrDefault(bucketEntry => bucketEntry.BucketId == bucketId);

        if (bucketEntry is null)
        {
            return Errors.Profile.CannotFindCloth;
        }

        return _bucketEntries.Remove(bucketEntry);
    }

    public ErrorOr<bool> ConvertToEcoCoins(int sustainabilityPoints)
    {
        if (sustainabilityPoints < 0)
        {
            return Errors.Profile.CannotConvertNegativeEcoCoins;
        }

        if (SustainabilityPoints < sustainabilityPoints)
        {
            return Errors.Profile.NotEnoughEcoCoins;
        }

        var oldEcoCoins = EcoCoins;
        EcoCoins += sustainabilityPoints * ConvertConcurrencyRange;

        var delta = EcoCoins - oldEcoCoins;
        if (delta > 0)
        {
            SustainabilityPoints -= sustainabilityPoints;
        }

        return true;
    }

    public ErrorOr<bool> ConvertToSustainabilityPoints(int ecoCoins)
    {
        if (ecoCoins < 0)
        {
            return Errors.Profile.CannotConvertNegativeEcoCoins;
        }

        if (EcoCoins < ecoCoins)
        {
            return Errors.Profile.NotEnoughEcoCoins;
        }

        var oldSustainabilityPoints = SustainabilityPoints;
        SustainabilityPoints += ecoCoins / ConvertConcurrencyRange;

        var delta = SustainabilityPoints - oldSustainabilityPoints;
        if (delta > 0)
        {
            EcoCoins -= ecoCoins;
        }

        return true;
    }

    public void Update
    (
        UserName? userName,
        Phone? phone
    )
    {
        if (userName is not null)
        {
            UserName = userName;
        }

        if (phone is not null)
        {
            Phone = phone;
        }
    }
}