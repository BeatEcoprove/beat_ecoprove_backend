using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public class Profile : Entity<ProfileId>
{
    private Profile(
        UserName userName,
        Gender gender,
        double xp,
        DateOnly bornDate,
        int sustainabilityPoints,
        double ecoScore,
        string avatarUrl)
    {
        UserName = userName;
        Gender = gender;
        Xp = xp;
        BornDate = bornDate;
        SustainabilityPoints = sustainabilityPoints;
        EcoScore = ecoScore;
        AvatarUrl = avatarUrl;
    }

    public UserName UserName { get; private set; }
    public Gender Gender { get; private set; }
    public double Xp { get; private set; }
    public DateOnly BornDate { get; private set; }
    public int SustainabilityPoints { get; private set; }
    public double EcoScore { get; private set; }
    public string AvatarUrl { get; private set; }

    public static Profile Create(UserName userName, Gender gender, double xp, DateOnly bornDate, int sustainabilityPoints, double ecoScore, string avatarUrl)
    {
        return new Profile(userName, gender, xp, bornDate, sustainabilityPoints, ecoScore, avatarUrl);
    }
}