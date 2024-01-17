using BeatEcoprove.Application.Shared.Interfaces.Services;

namespace BeatEcoprove.Infrastructure.Gaming;

public class GamingService : IGamingService
{
    private const double BaseXp = 5000;
    
    public double CalculateXp(int level)
    {
        // each level increment 2 times
        return level * level * BaseXp;
    }
    
    public double CalculateLevelProgress(int level, double xp)
    {
        // Assuming a custom progression formula: XP = Level^2 * 100
        double xpRequiredForCurrentLevel = CalculateXp(level);
        double xpRequiredForNextLevel = CalculateXp(level + 1);

        double xpRange = Math.Abs(xpRequiredForNextLevel - xpRequiredForCurrentLevel);
        double xpProgress = xpRequiredForCurrentLevel - xp;
        
        // Calculate percentage
        return (xpRange == 0) ? 100 : xpProgress / xpRange * 100;
    }
}
