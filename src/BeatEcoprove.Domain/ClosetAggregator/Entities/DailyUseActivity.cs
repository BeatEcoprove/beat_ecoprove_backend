using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public class DailyUseActivity : Activity
{
    private const int CoolDownInHours = 10;
    
    private DailyUseActivity() { }
    
    private DailyUseActivity(
        ProfileId profileId, 
        ClothId clothId, 
        float xp = 0, 
        float deltaScore = 0,
        int dailySequence = 0) : base(profileId, clothId, xp, deltaScore)
    {
        DailySequence = dailySequence;
        PointsOfSustentability = 0;
    }

    public int DailySequence { get; private set; }
    public int PointsOfSustentability { get; private set; }
    
    public static DailyUseActivity Create(
        ProfileId profile, 
        ClothId cloth, 
        float xp = 0, 
        float deltaScore = 0)
    {
        return new DailyUseActivity(
            profile, 
            cloth, 
            xp, 
            deltaScore);
    }
}