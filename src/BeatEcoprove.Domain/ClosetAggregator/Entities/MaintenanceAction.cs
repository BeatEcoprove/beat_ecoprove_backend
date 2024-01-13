using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public class MaintenanceAction : Entity<MaintenanceActionId>
{
    private MaintenanceAction() { }

    private MaintenanceAction(
        MaintenanceActionId id,
        MaintenanceServiceId maintenanceServiceId,
        string title, 
        string description, 
        string badge)
    {
        Id = id;
        Title = title;
        Description = description;
        Badge = badge;
        MaintenanceService = maintenanceServiceId;
    }

    public MaintenanceServiceId MaintenanceService { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Badge { get; private set; }
    
    public static MaintenanceAction Create(
        MaintenanceServiceId maintenanceServiceId,
        string title, 
        string description, 
        string badge)
    {
        return new MaintenanceAction(
            MaintenanceActionId.CreateUnique(), 
            maintenanceServiceId,
            title, 
            description, 
            badge);
    }
}