using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class BucketRepository : Repository<Bucket, BucketId>, IBucketRepository
{
    public BucketRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> CanAddClothsAsync(BucketId bucketId, List<ClothId> clothIds, CancellationToken cancellationToken)
    {
        var clothAlreadyAddedToBucket =
            from bucket in DbContext.Buckets
            from bucketEntry in bucket.BucketClothEntries
            where clothIds.Contains(bucketEntry.ClothId)
            select bucketEntry.ClothId;

        return !await clothAlreadyAddedToBucket.AnyAsync(cancellationToken);
    }
}