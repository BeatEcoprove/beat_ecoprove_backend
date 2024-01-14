using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public class MaintenanceService : Entity<MaintenanceServiceId>
{
    private readonly List<MaintenanceAction> _maintenanceActions = new();
    private MaintenanceService() { }

    private MaintenanceService(
        MaintenanceServiceId id,
        string badge, 
        string title, 
        string description)
    {
        Id = id;
        Badge = badge;
        Title = title;
        Description = description;
    }

    public string Badge { get; private set; } = null!;
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public IReadOnlyList<MaintenanceAction> MaintenanceActions => _maintenanceActions.AsReadOnly();

    public static MaintenanceService Create(
        string badge, 
        string title, 
        string description)
    {
        return new MaintenanceService(
            MaintenanceServiceId.CreateUnique(), 
            badge, 
            title, 
            description);
    }
}