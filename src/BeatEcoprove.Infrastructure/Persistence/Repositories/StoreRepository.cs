using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
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
    public StoreRepository(
        IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public new async Task<Store?> GetByIdAsync(StoreId id, CancellationToken cancellationToken = default)
    {
         return await DbContext.Set<Store>()
            .Include(group => group.Workers)
            .Include(group => group.Orders)
            .Include(group => group.Ratings)
            .FirstOrDefaultAsync(group => group.Id == id, cancellationToken);
    }

    public Task<bool> ExistsAnyStoreWithName(string name, CancellationToken cancellationToken = default)
    {
        return DbContext.Set<Store>()
            .AnyAsync(store => store.Name == name, cancellationToken);
    }

    public async Task<bool> HasAccessToStore(
        StoreId id, 
        Profile manager, 
        bool isEmployee = false,
        CancellationToken cancellationToken = default)
    {
        var query = from store in DbContext.Set<Store>()
            where 
                (
                    isEmployee && store.Workers.Select(worker => worker.Profile).Contains(manager.Id) ||
                    store.Owner == manager.Id
                ) &&
                store.Id == id 
            select store;

        return await query.AnyAsync(cancellationToken);
    }

    public async Task<List<Store>> GetOwningStoreAsync(
        ProfileId owner, 
        bool isEmployee = false,
        string? search = null,
        int page = 1, 
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        var allMyStores = from store in DbContext.Set<Store>()
            where 
                (   
                    isEmployee && store.Workers.Select(worker => worker.Profile).Contains(owner) ||
                    store.Owner == owner
                ) &&
                (search == null || store.Name.ToLower().Contains(search.ToLower()))
            select store;
        
        allMyStores = allMyStores
            .Include(a => a.Ratings)
            .Include(a => a.Workers)
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await allMyStores.ToListAsync(cancellationToken);
    }

    public async Task<List<Order>> GetAllStoresAsync(
        Guid owner, 
        string? search, 
        List<Guid>? services = null, 
        List<Guid>? colorValue = null, 
        List<Guid>? brandValue = null,
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

    public async Task<Order?> GetOrderAsync(OrderId orderId, CancellationToken cancellationToken = default)
    {
        var getOrderById = from order in DbContext.Set<Order>()
            where order.Id == orderId
            select order;

        return await getOrderById.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<OrderDAO?> GetOrderDaoAsync(
        OrderId orderId, 
        CancellationToken cancellationToken = default)
    {
         var getOrderById = from store in DbContext.Set<Store>()
            from order in store.Orders
            from cloth in DbContext.Set<Cloth>()
            from brand in DbContext.Set<Brand>()
            from color in DbContext.Set<Color>()
            from profile in DbContext.Set<Profile>()
            let orderCloth = order as OrderCloth
            let isOrderCloth = orderCloth != null
            where    
                order.Id == orderId &&
                (
                    !isOrderCloth ||
                    brand.Id == cloth.Brand &&
                    cloth.Color == color.Id &&
                    orderCloth.Cloth == cloth.Id
                ) 
        let orderServices = (
                from service in DbContext.Set<MaintenanceService>()
                where 
                    order.Services.Select(entry => entry.Service).Contains(service.Id)
                select new MaintenanceOrderDao(
                    service.Id,
                    service.Title,
                    service.Badge
                )
            ).ToList()
        where 
            orderServices.Count > 0 &&
            profile.Id == order.Owner
        select isOrderCloth
            ? orderCloth.ToOrderCloth(
                cloth, 
                brand, 
                color,
                profile,
                orderServices
            ) : order.ToOrderDao(profile, orderServices);

         return await getOrderById.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<List<OrderDAO>> GetOrderDaosAsync(
        List<StoreId> storeId,
        string? search,
        List<Guid>? serviceValue = null,
        List<Guid>? colorValue = null,
        List<Guid>? brandValue = null,
        bool? isDone = null,
        int page = 10,
        int pageSize = 1,
        CancellationToken cancellationToken = default)
    {
        var orderGetAll = from store in DbContext.Set<Store>()
            from order in store.Orders
            from cloth in DbContext.Set<Cloth>()
            from brand in DbContext.Set<Brand>()
            from color in DbContext.Set<Color>()
            from profile in DbContext.Set<Profile>()
            let orderCloth = order as OrderCloth
            let isOrderCloth = orderCloth != null
            where
                storeId.Contains(store.Id) &&
                order.Store == store.Id &&
                (
                    !isOrderCloth ||
                    brand.Id == cloth.Brand &&
                    cloth.Color == color.Id &&
                    orderCloth.Cloth == cloth.Id &&
                    (brandValue == null || brandValue.Contains(brand.Id)) &&
                    (colorValue == null || colorValue.Contains(color.Id))
                ) 
            let orderServices = (
                    from service in DbContext.Set<MaintenanceService>()
                    where 
                        order.Services.Select(entry => entry.Service).Contains(service.Id) &&
                        (serviceValue == null || serviceValue.Contains(service.Id))
                    select new MaintenanceOrderDao(
                        service.Id,
                        service.Title,
                        service.Badge
                    )
                ).ToList()
            where 
                orderServices.Count > 0 &&
                (search == null || cloth.Name.ToLower().Contains(search.ToLower()) || brand.Name.ToLower().Contains(search.ToLower())) &&
                (isDone == null || (bool)isDone ? order.Status == OrderStatus.Completed : order.Status != OrderStatus.Completed ) &&
                profile.Id == order.Owner
            select isOrderCloth
                ? orderCloth.ToOrderCloth(
                    cloth, 
                    brand, 
                    color,
                    profile,
                    orderServices
                ) : order.ToOrderDao(profile, orderServices);
        
       orderGetAll = orderGetAll
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await orderGetAll
            .ToListAsync(cancellationToken);
    }

    public async Task<WorkerDao?> GetWorkerDaoAsync(WorkerId workerId, CancellationToken cancellationToken = default)
    {
        var getWorker = from store in DbContext.Set<Store>()
            from worker in store.Workers
            from profile in DbContext.Set<Profile>()
            from auth in DbContext.Set<Auth>()
            where 
                worker.Store == store.Id &&
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

    public async Task<List<WorkerDao>> GetWorkerDaosAsync(StoreId storeId, string? search = null, int page = 1, int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        var getWorkers = from store in DbContext.Set<Store>()
            from worker in store.Workers
            from profile in DbContext.Set<Profile>()
            from auth in DbContext.Set<Auth>()
            where 
                    store.Id == storeId &&
                    worker.Profile == profile.Id && profile.AuthId == auth.Id && 
                    (search == null || ((string)profile.UserName).ToLower().Contains(search.ToLower()))
            select new WorkerDao(
                worker.Id,
                profile.UserName,
                auth.Email,
                worker.Role
            );
        
        getWorkers = getWorkers
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await getWorkers.ToListAsync(cancellationToken);
    }

    public async Task<bool> RemoveWorkerAsync(WorkerId id, CancellationToken cancellationToken = default)
    {
        var worker = await DbContext
            .Set<Worker>()
            .FirstOrDefaultAsync(w => w.Id == id, cancellationToken);

        if (worker is null)
        {
            return false;
        }

        DbContext.Set<Worker>().Remove(worker);
        return true;
    }

    public async Task<Worker?> GetWorkerByProfileAsync(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        var getProfile = from worker in DbContext.Set<Worker>()
            from profile in DbContext.Set<Profile>()
            where worker.Profile == profileId
            select worker;

        return await getProfile.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<Worker?> GetWorkerAsync(WorkerId workerId, CancellationToken cancellationToken = default)
    {
        return await DbContext.Set<Worker>()
            .FirstOrDefaultAsync(s => s.Id == workerId, cancellationToken);
    }

    public Task<bool> WorkerAlreadyOnStore(WorkerId workerId, StoreId storeId, CancellationToken cancellationToken = default)
    {
        var workerAlreadyOnStore = from store in DbContext.Set<Store>()
            from worker in store.Workers
            where store.Id == storeId && worker.Id == workerId
            select worker;

        return workerAlreadyOnStore.AnyAsync(cancellationToken);
    }

    public Task<List<RatingDao>> GetRatingsFromStore(StoreId id, CancellationToken cancellationToken = default)
    {
        var getAllRatings = from store in DbContext.Set<Store>()
            from rating in store.Ratings
            from profile in DbContext.Set<Profile>()
            where
                store.Id == id && 
                rating.Store == store.Id &&
                profile.Id == rating.User
            select new RatingDao(
                rating.Store,
                rating.Rate,
                profile
            );

        return getAllRatings.ToListAsync(cancellationToken);
    }

    public async Task<bool> DeleteStoreAsync(Store store, CancellationToken cancellationToken)
    {
        var foundStore = await DbContext
            .Set<Store>()
            .FirstOrDefaultAsync(s => s.Id == store.Id, cancellationToken);
        
        if (foundStore is null)
        {
            return false;
        }
        
        DbContext.Set<Store>().Remove(foundStore);
        return true;
    }
}