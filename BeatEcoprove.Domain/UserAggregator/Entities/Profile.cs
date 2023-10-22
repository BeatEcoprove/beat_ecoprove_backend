using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public class Profile : Entity<ProfileId>
{
    private Profile(
        UserName userName,
        Gender gender,
        DateOnly bornDate,
        string avatarUrl,
        double xp,
        double sustainabilityPoints,
        double ecoScore)
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
    public double SustainabilityPoints { get; private set; }
    public double EcoScore { get; private set; }
    public string AvatarUrl { get; private set; }

    public static Profile Create(UserName userName, Gender gender, DateOnly bornDate, string avatarUrl)
    {
        return new Profile(userName, gender, bornDate, avatarUrl, 0, 0 , 0);
    }
}