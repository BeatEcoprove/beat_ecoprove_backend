using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class MaintenanceServiceRepository : Repository<MaintenanceService, MaintenanceServiceId>, IMaintenanceServiceRepository
{
    public MaintenanceServiceRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<MaintenanceService>> GetAllServicesAsync(CancellationToken cancellationToken = default)
    {
        return await
            DbContext.Set<MaintenanceService>()
                .Include(service =>
                    service.MaintenanceActions
                        .OrderBy(a => a.Title))
                .OrderBy(a => a.Title)
                .ToListAsync(cancellationToken);
    }

    public async Task<bool> ExistServiceByIdAsync(MaintenanceServiceId serviceId, CancellationToken cancellationToken)
    {
        return await DbContext.Set<MaintenanceService>()
            .AnyAsync(service => service.Id == serviceId, cancellationToken);
    }

    public async Task<bool> ExistActionByIdAsync(MaintenanceActionId actionId, CancellationToken cancellationToken)
    {
        return await DbContext.Set<MaintenanceAction>()
            .AnyAsync(action => action.Id == actionId, cancellationToken);
    }

    public Task<MaintenanceAction?> GetActionByIdAsync(MaintenanceActionId actionId, CancellationToken cancellationToken)
    {
        return DbContext.Set<MaintenanceAction>()
            .FirstOrDefaultAsync(action => action.Id == actionId, cancellationToken);
    }
}