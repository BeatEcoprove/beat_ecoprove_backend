using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Extensions;
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

    public async Task<OrderDAO?> GetOrderDaoAsync(OrderId orderId, CancellationToken cancellationToken = default)
    {
        List<MaintenanceOrderDao> servicesDao = new();
        
        var orderGetCloth = from store in DbContext.Set<Store>()
            from order in store.Orders
            from cloth in DbContext.Set<Cloth>()
            from brand in DbContext.Set<Brand>()
            from color in DbContext.Set<Color>()
            where (order.Type.Equals(OrderType.Cloth) &&
                   brand.Id == cloth.Brand &&
                   color.Id == cloth.Color && 
                   order.Id == orderId) ||
                  ( order.Type.Equals(OrderType.Bucket) )
            select new
            {
                Order = order, 
                Cloth = cloth, 
                Brand = brand, 
                Color = color
            };

        var orderSegment = await orderGetCloth.FirstOrDefaultAsync(cancellationToken);

        if (orderSegment is null)
        {
            return null;
        }

        foreach (var entry in orderSegment.Order.Services)
        {
            var service = await DbContext.Set<MaintenanceService>()
                .Where(service => service.Id == entry.Service)
                .FirstOrDefaultAsync(cancellationToken);

            if (service is null)
            {
                continue;
            }
            
            servicesDao.Add(new MaintenanceOrderDao(
                service.Id,
                service.Title,
                service.Badge
            ));
        }

        var dao = orderSegment.Order switch
        {
            OrderCloth orderCloth => orderCloth.ToOrderCloth(
                orderSegment.Cloth,
                orderSegment.Brand,
                orderSegment.Color
            ),
            _ => orderSegment.Order.ToOrderDao()
        };

        dao.MaintenanceServices.AddRange(servicesDao);
        return dao;
    }

    public async Task<WorkerDao?> GetWorkerDaoAsync(WorkerId workerId, CancellationToken cancellationToken = default)
    {
        var getWorker = from store in DbContext.Set<Store>()
            from worker in store.Workers
            from profile in DbContext.Set<Profile>()
            from auth in DbContext.Set<Auth>()
            where 
                worker.Id == workerId && 
                worker.Profile == profile.Id &&
                profile.AuthId == auth.Id
            select new WorkerDao(
                worker.Id,
                profile.UserName,
                auth.Email,
                worker.Role
            );

        return await getWorker.FirstOrDefaultAsync(cancellationToken);
    }
}