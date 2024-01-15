using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IMaintenanceServiceRepository : IRepository<MaintenanceService, MaintenanceServiceId>
{
    Task<List<MaintenanceService>> GetAllServicesAsync(CancellationToken cancellationToken = default);
    Task<bool> ExistServiceByIdAsync(MaintenanceServiceId serviceId, CancellationToken cancellationToken);
    Task<bool> ExistActionByIdAsync(MaintenanceActionId actionId, CancellationToken cancellationToken);
    Task<MaintenanceAction?> GetActionByIdAsync(MaintenanceActionId actionId, CancellationToken cancellationToken);
}