using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
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

    public async Task<List<Order>> GetAllStoresAsync(
        Guid owner, 
        string? search, 
        List<Guid>? services = null, 
        List<Guid>? colorValue = null, 
        List<Guid>? brandValue = null,
        string? orderValue = null, 
        int pageSize = 10, 
        int page = 1,
        CancellationToken cancellationToken = default)
    {
        var getAllOrders =
            from store in DbContext.Set<Store>()
            from order in store.Orders
            where store.Owner == owner
            select order;

        getAllOrders = from order in getAllOrders
            from cloth in DbContext.Set<Cloth>()
            from color in DbContext.Set<Color>()
            where 
                order.Type.Equals(OrderType.Cloth) &&
                cloth.Color == color.Id &&
                (colorValue == null || colorValue.Contains(color.Id))
            select order;
            
        getAllOrders = getAllOrders
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await getAllOrders
            .ToListAsync(cancellationToken);
    }
}