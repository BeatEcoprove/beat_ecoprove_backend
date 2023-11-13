using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class BucketRepository : Repository<Bucket, BucketId>, IBucketRepository
{
    public BucketRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}