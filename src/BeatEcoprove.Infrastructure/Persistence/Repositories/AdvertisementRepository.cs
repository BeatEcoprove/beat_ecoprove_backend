using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class AdvertisementRepository : Repository<Advertisement, AdvertisementId>, IAdvertisementRepository
{
    public AdvertisementRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Advertisement>> GetAllAddsAsync(
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
}