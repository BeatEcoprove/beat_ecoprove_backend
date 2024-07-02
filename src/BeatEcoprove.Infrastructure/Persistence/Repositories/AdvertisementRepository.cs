using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class AdvertisementRepository : Repository<Advertisement, AdvertisementId>, IAdvertisementRepository
{
    public AdvertisementRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}