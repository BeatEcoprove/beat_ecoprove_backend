using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities;


public abstract class Profile : AggregateRoot<ProfileId, Guid>
{
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
}
