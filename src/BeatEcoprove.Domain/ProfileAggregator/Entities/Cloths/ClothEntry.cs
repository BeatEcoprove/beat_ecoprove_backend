using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class ClothEntry
{
    public ClothEntry(
        ProfileId profileId, 
        ClothId clothId)
    {
        ProfileId = profileId;
        ClothId = clothId;
        IsBlocked = false;
    }

    public ProfileId ProfileId { get; private set; }
    public ClothId ClothId { get; private set; }
    public bool IsBlocked { get; private set; }
}