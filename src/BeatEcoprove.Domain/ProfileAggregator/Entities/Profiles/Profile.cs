using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;


public abstract class Profile : AggregateRoot<ProfileId, Guid>
{
    private readonly List<ClothEntry> _clothEntries = new();
    private readonly List<BucketEntry> _bucketEntries = new();
    
    protected Profile()
    {
    }

    protected Profile(
        AuthId authCredentials,
        UserName userName,
        Phone phone,
        double xP,
        int sustainabilityPoints,
        int ecoScore,
        string avatarUrl, UserType type)
    {
        Id = ProfileId.CreateUnique();
        AuthId = authCredentials;
        UserName = userName;
        Phone = phone;
        XP = xP;
        SustainabilityPoints = sustainabilityPoints;
        EcoScore = ecoScore;
        AvatarUrl = avatarUrl;
        Type = type;
    }

    public AuthId AuthId { get; protected set; } = null!;
    public UserName UserName { get; protected set; } = null!;
    public Phone Phone { get; protected set; } = null!;
    public double XP { get; protected set; }
    public int SustainabilityPoints { get; protected set; }
    public int EcoScore { get; protected set; }
    public string AvatarUrl { get; protected set; } = null!;
    public UserType Type { get; protected set; } = null!;
    public IReadOnlyList<ClothEntry> ClothEntries => _clothEntries.AsReadOnly();
    public IReadOnlyList<BucketEntry> BucketEntries => _bucketEntries.AsReadOnly();
    
    public void AddCloth(Cloth cloth)
    {
        _clothEntries.Add(
            new ClothEntry(this.Id, cloth.Id));
    }
    
    public void AddBucket(Bucket bucket)
    {
        _bucketEntries.Add(
            new BucketEntry(this.Id, bucket.Id));
    }
}
