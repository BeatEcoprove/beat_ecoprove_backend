using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public abstract class Activity : Entity<ActivityId>
{
    protected Activity() { }
    
    protected Activity(
        ProfileId profileId, 
        ClothId clothId, 
        float xp = 0, 
        float deltaScore = 0)
    {
        Id = ActivityId.CreateUnique();
        ClothId = clothId;
        ProfileId = profileId;
        XP = xp;
        DeltaScore = deltaScore;
        CreatedAt = DateTime.UtcNow;
    }
    
    public ClothId ClothId { get; protected set; }
    public ProfileId ProfileId { get; protected set; }
    public float XP { get; protected set; }
    public float DeltaScore { get; protected set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime EndAt { get; private set; }
    
    public void EndActivity()
    {
        EndAt = DateTime.UtcNow;
    }
    
    public bool IsRunning()
    {
        return EndAt == default;
    }
}