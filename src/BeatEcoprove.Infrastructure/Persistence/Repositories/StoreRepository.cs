using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class StoreRepository : Repository<Store, StoreId>, IStoreRepository
{
    public StoreRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task<bool> ExistsAnyStoreWithName(string name, CancellationToken cancellationToken = default)
    {
        return DbContext.Set<Store>()
            .AnyAsync(store => store.Name == name, cancellationToken);
    }
}