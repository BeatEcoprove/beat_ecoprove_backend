using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;
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

    public async Task<bool> HasAccessToStore(StoreId id, Profile manager, CancellationToken cancellationToken = default)
    {
        var query = from store in DbContext.Set<Store>()
            where store.Id == id && store.Owner == manager.Id
            select store;

        return await query.AnyAsync(cancellationToken);
    }
}