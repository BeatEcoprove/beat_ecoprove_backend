using BeatEcoprove.Application.Shared.Gaming;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IGamingService
{
    double GetLevelProgress(IGamingObject profile);
    void GainXp(IGamingObject profile, double xp);
    double GetNextLevelXp(IGamingObject profile);
}