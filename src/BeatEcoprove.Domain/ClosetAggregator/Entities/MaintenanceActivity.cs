using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public class MaintenanceActivity : Activity
{
    private readonly List<MaintenanceService> _maintenanceServices = new();
    
    private MaintenanceActivity() { }
    
    private MaintenanceActivity(
        ProfileId profileId, 
        ClothId clothId,
        string title,
        string badge,
        int pointsOfSustentability,
        float xp = 0, 
        float deltaScore = 0) : base(profileId, clothId, xp, deltaScore)
    {
        Title = title;
        Badge = badge;
        PointsOfSustentability = pointsOfSustentability;
    }

    public string Title { get; private set; }
    public string Badge { get; private set; }
    public int PointsOfSustentability { get; private set; }
    public IReadOnlyList<MaintenanceService> MaintenanceServices => _maintenanceServices;
    
    public static MaintenanceActivity Create(
        ProfileId profileId, 
        ClothId clothId,
        string title,
        string badge,
        int pointsOfSustentability,
        float xp = 0, 
        float deltaScore = 0)
    {
        return new MaintenanceActivity(
            profileId, 
            clothId, 
            title,
            badge,
            pointsOfSustentability,
            xp, 
            deltaScore);
    }
}