using BeatEcoprove.Application.Shared.Gaming;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Infrastructure.Gaming;

public class GamingService : IGamingService
{
    private const double BaseXp = 25;

    public double GetLevelProgress(IGamingObject profile)
    {
        double xpRequiredForCurrentLevel = BaseXp * profile.Level;
        double xpRequiredForNextLevel = BaseXp * (profile.Level + 1);

        double xpRange = xpRequiredForNextLevel - xpRequiredForCurrentLevel;

        if (xpRange == 0)
        {
            return 100;
        }

        var xpProgress = profile.XP - xpRequiredForCurrentLevel;

        return xpProgress / xpRange * 100;
    }

    public double GetNextLevelXp(IGamingObject profile)
    {
        return BaseXp * (profile.Level + 1);
    }

    public void GainXp(IGamingObject profile, double xp)
    {
        profile.XP += xp;
        CheckLevelUp(profile);
    }

    private static void CheckLevelUp(IGamingObject profile)
    {
        var xpRequiredByLevel = BaseXp * (profile.Level + 1);

        if (!(profile.XP >= xpRequiredByLevel)) return;

        profile.Level++;
    }
}