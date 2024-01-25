using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class BucketRepository : Repository<Bucket, BucketId>, IBucketRepository
{
    public BucketRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
    
    public async Task<Bucket?> GetByIdWithClothAsync(BucketId bucketId, CancellationToken cancellationToken)
    {
        return await DbContext
            .Buckets
            .Include(bucket => bucket.BucketClothEntries)
            .SingleOrDefaultAsync(bucket => bucket.Id == bucketId, cancellationToken);
    }

    public async Task<bool> IsBucketNameAlreadyUsed(ProfileId profileId, BucketId bucketId, string name,
        CancellationToken cancellationToken = default)
    {
        var bucketNameAlreadyUsed =
            from bucket in DbContext.Buckets
            from profile in DbContext.Profiles
            from bucketEntry in profile.BucketEntries
            where bucketEntry.BucketId != bucketId && bucketEntry.ProfileId == profileId && bucket.Name == name
            select bucket.Name;
        
        return await bucketNameAlreadyUsed.AnyAsync(cancellationToken);
    }

    public async Task<bool> AreClothAlreadyOnBucket(List<ClothId> clothIds, CancellationToken cancellationToken)
    {
        var clothAlreadyAddedToBucket =
            from bucket in DbContext.Buckets
            from bucketEntry in bucket.BucketClothEntries
            where clothIds.Contains(bucketEntry.ClothId)
            select bucketEntry.ClothId;

        return await clothAlreadyAddedToBucket.AnyAsync(cancellationToken);
    }

    public Task<List<ClothDao>> GetClothsAsync(BucketId bucketId, CancellationToken cancellationToken)
    {
        var getBucketCloths =
            from bucket in DbContext.Buckets
            from cloth in DbContext.Cloths
            from color in DbContext.Set<Color>()
            from brand in DbContext.Set<Brand>()
            from bucketEntry in bucket.BucketClothEntries
            where bucket.Id == bucketId && bucketEntry.ClothId == cloth.Id && cloth.Color == color.Id && cloth.Brand == brand.Id
            select new ClothDao(
                cloth.Id,
                cloth.Name,
                cloth.Type.ToString(),
                cloth.Size.ToString(),
                brand.Name,
                color.Hex,
                cloth.EcoScore,
                cloth.State.ToString(),
                cloth.ClothAvatar
                );
        
        return getBucketCloths.ToListAsync(cancellationToken);
    }

    public async Task<(bool, Bucket)> CheckIfClothBelongsToAnBucket(ClothId clothId, CancellationToken cancellationToken = default)
    {
        var checkIfClothBelongsToBucket =
            from bucketEntry in DbContext.Buckets
            from bucketClothEntry in bucketEntry.BucketClothEntries
            where bucketClothEntry.ClothId == clothId
            select bucketEntry;
        
        var result = await checkIfClothBelongsToBucket.FirstOrDefaultAsync(cancellationToken);
        
        return (result is not null, result!);
    }

    public async Task RemoveByIdAsync(BucketId bucketId, CancellationToken cancellationToken)
    {
        var bucket = await DbContext
            .Buckets
            .SingleOrDefaultAsync(bucket => bucket.Id == bucketId, cancellationToken);

        if (bucket is null)
        {
            throw new Exception("Cloth not found");
        }

        DbContext.Buckets.Remove(bucket);
    }
}