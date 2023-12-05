using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public class MaintenanceService : Entity<MaintenanceServiceId>
{
    private MaintenanceService() { }

    private MaintenanceService(
        ActivityId maintenanceActivityId, 
        string badge, 
        string title, 
        string description)
    {
        MaintenanceActivityId = maintenanceActivityId;
        Badge = badge;
        Title = title;
        Description = description;
    }

    public ActivityId MaintenanceActivityId { get; private set; }
    public string Badge { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    public static MaintenanceService Create(
        ActivityId maintenanceId, 
        string badge, 
        string title, 
        string description)
    {
        return new MaintenanceService(
            maintenanceId, 
            badge, 
            title, 
            description);
    }
}