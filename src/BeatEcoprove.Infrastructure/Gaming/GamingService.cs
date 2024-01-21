using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Infrastructure.Gaming;

public class GamingService : IGamingService
{
    private const double BaseXp = 5000;

    public double GetLevelProgress(Profile profile)
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



    public void GainXp(Profile profile, double xp)
    {
        profile.XP += xp;
        CheckLevelUp(profile);
    }

    private static void CheckLevelUp(Profile profile)
    {
        var xpRequiredByLevel = BaseXp * (profile.Level + 1);

        if (!(profile.XP >= xpRequiredByLevel)) return;
        
        profile.Level++;
    }
}
