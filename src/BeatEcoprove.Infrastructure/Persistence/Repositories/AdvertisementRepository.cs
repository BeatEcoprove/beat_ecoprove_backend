using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class AdvertisementRepository : Repository<Advertisement, AdvertisementId>, IAdvertisementRepository
{
    public AdvertisementRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Advertisement>> GetAllHomeAdds(
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        var getAllAdverts = from advert in DbContext.Set<Advertisement>()
            where 
                (search == null || ((string)advert.Title).ToLower().Contains(search.ToLower()))
            select advert;
        
        getAllAdverts = getAllAdverts
            .Skip((page - 1) * pageSize)
            .Take(pageSize);
        
        return await getAllAdverts.ToListAsync(cancellationToken);
    }
    
    public async Task<List<Advertisement>> GetAllAddsAsync(
        ProfileId profile,
        bool isEmployee = false,
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        var getAllAdverts = from advert in DbContext.Set<Advertisement>()
            from store in DbContext.Set<Store>()
            from worker in store.Workers
            where 
                (
                    isEmployee && advert.Store == null 
                    ||
                    isEmployee && advert.Store == store.Id && worker.Profile == profile && worker.Store == store.Id
                    ||
                    advert.Creator == profile
                ) &&
                (search == null || ((string)advert.Title).ToLower().Contains(search.ToLower()))
            select advert;
       
        getAllAdverts = getAllAdverts
            .Distinct()
            .Skip((page - 1) * pageSize)
            .Take(pageSize);
        
        return (await getAllAdverts.ToListAsync(cancellationToken));
    }

    public async Task<bool> HasProfileAccessToAdvert(
        AdvertisementId advertId, 
        ProfileId profile,
        bool isEmployee = false,
        CancellationToken cancellationToken = default)
    {
        var hasAccess = from advert in DbContext.Set<Advertisement>()
            from store in DbContext.Set<Store>()
            from worker in store.Workers
            where 
                 (
                    isEmployee && advert.Store == null 
                    ||
                    isEmployee && advert.Store == store.Id && worker.Profile == profile && worker.Store == store.Id
                    ||
                    advert.Creator == profile
                ) 
            select advert;

        return await hasAccess.AnyAsync(cancellationToken);
    }

    public async Task RemoveAsync(AdvertisementId id, CancellationToken cancellationToken = default)
    {
        await DbContext.Set<Advertisement>()
            .Where(add => add.Id == id)
            .ExecuteDeleteAsync(cancellationToken);
    }
}