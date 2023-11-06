using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;

public class ClothEntry
{
    public ClothEntry(
        ProfileId profileId, 
        ClothId cloth)
    {
        ProfileId = profileId;
        Cloth = cloth;
        IsBlocked = false;
    }

    public ProfileId ProfileId { get; private set; }
    public ClothId Cloth { get; private set; }
    public bool IsBlocked { get; private set; }
}