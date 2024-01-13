namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IGamingService
{
    double CalculateXp(int level);
    double CalculateLevelProgress(int level, double xp);
}