using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public class Profile : Entity<ProfileId>
{
    private readonly List<Garment> _garments = new();

    public Profile() { }

    private Profile(
        UserId consumer,
        ProfileId id,
        UserName userName,
        Gender gender,
        DateOnly bornDate,
        string avatarUrl,
        double xp,
        double sustainabilityPoints,
        double ecoScore,
        bool isMainProfile)
    {
        Id = id;
        UserName = userName;
        Gender = gender;
        Xp = xp;
        BornDate = bornDate;
        SustainabilityPoints = sustainabilityPoints;
        EcoScore = ecoScore;
        AvatarUrl = avatarUrl;
        IsMainProfile = isMainProfile;
    }
    public UserId Consumer { get; set; } = null!;
    public UserName UserName { get; private set; } = null!;
    public Gender Gender { get; private set; }
    public double Xp { get; private set; }
    public DateOnly BornDate { get; private set; }
    public double SustainabilityPoints { get; private set; }
    public double EcoScore { get; private set; }
    public string AvatarUrl { get; private set; } = null!;
    public bool IsMainProfile { get; private set; }
    public IReadOnlyList<Garment> Garments => _garments.AsReadOnly();

    public static Profile Create(UserId consumer, UserName userName, Gender gender, DateOnly bornDate, string avatarUrl)
    {
        return new Profile(
            consumer,
            ProfileId.CreateUnique(),
            userName,
            gender,
            bornDate,
            avatarUrl,
            0,
            0,
            0,
            false);
    }

    public void SetAsMainProfile() => IsMainProfile = true;

    public void AddGarment(Garment garment)
    {
        _garments.Add(garment);
    }

    public Profile Clone()
    {
        return Profile.Create(
            Consumer,
            UserName,
            Gender,
            BornDate,
            AvatarUrl);
    }
}