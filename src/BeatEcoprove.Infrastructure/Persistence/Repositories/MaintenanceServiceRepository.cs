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
                .Include(service => service.MaintenanceActions)
                .ToListAsync(cancellationToken);
    }
}