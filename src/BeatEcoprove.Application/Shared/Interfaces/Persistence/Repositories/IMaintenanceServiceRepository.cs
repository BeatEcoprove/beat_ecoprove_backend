using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IMaintenanceServiceRepository : IRepository<MaintenanceService, MaintenanceServiceId>
{
    Task<List<MaintenanceService>> GetAllServicesAsync(CancellationToken cancellationToken = default);
}