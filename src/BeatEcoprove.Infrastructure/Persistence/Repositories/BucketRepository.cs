using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class BucketRepository : Repository<Bucket, BucketId>, IBucketRepository
{
    public BucketRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}