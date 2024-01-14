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
        string badge,
        int sustainablePoints = 0)
    {
        Id = id;
        Title = title;
        Description = description;
        Badge = badge;
        MaintenanceService = maintenanceServiceId;
        SustainablePoints = sustainablePoints;
    }

    public MaintenanceServiceId MaintenanceService { get; private set; } = null!;
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string Badge { get; private set; } = null!;
    public int SustainablePoints { get; private set; }

    public static MaintenanceAction Create(
        MaintenanceServiceId maintenanceServiceId,
        string title, 
        string description, 
        string badge,
        int sustainablePoints = 0)
    {
        return new MaintenanceAction(
            MaintenanceActionId.CreateUnique(), 
            maintenanceServiceId,
            title, 
            description, 
            badge,
            sustainablePoints);
    }
}