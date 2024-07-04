using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IGamingService
{
    double GetLevelProgress(Profile profile);
    void GainXp(Profile profile, double xp);
    double GetNextLevelXp(Profile profile);
}