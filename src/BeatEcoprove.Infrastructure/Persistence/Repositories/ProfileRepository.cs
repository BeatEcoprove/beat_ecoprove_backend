using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ProfileRepository : Repository<Profile, ProfileId>, IProfileRepository
{
    public ProfileRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken)
    {
        return await DbContext
            .Profiles
            .AnyAsync(p => p.UserName == userName, cancellationToken);
    }

    public async Task<Profile?> GetProfileByAuthId(AuthId id, CancellationToken cancellationToken)
    {
        return await
            DbContext
            .Profiles
            .SingleOrDefaultAsync(p => p.AuthId == id, cancellationToken);
    }

    public async Task<List<ClothDao>> GetClosetCloth(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        var getAllCloth =
            from profile in DbContext.Profiles
            from clothEntry in profile.ClothEntries
            from color in DbContext.Set<Color>()
            from brand in DbContext.Set<Brand>()
            join cloth in DbContext.Cloths on clothEntry.ClothId equals cloth.Id
            where cloth.Color == color.Id && cloth.Brand == brand.Id
            select new ClothDao(
                cloth.Id,
                cloth.Name,
                cloth.Type.ToString(),
                cloth.Size.ToString(),
                brand.Name,
                color.Hex,
                cloth.EcoScore,
                cloth.ClothAvatar
            );

        return await getAllCloth.ToListAsync(cancellationToken);
    }

    public async Task<List<Bucket>> GetBucketCloth(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        var getAllBuckets =
            from profile in DbContext.Profiles
            from bucketEntry in profile.BucketEntries
            join bucket in DbContext.Buckets on bucketEntry.BucketId equals bucket.Id
            select bucket;

        return await getAllBuckets.ToListAsync(cancellationToken);
    }

    public Task<bool> CanProfileAccessBucket(ProfileId profileId, BucketId bucketId, CancellationToken cancellationToken = default)
    {
        var canAccessBucket =
            from profile in DbContext.Profiles
            from bucketEntry in profile.BucketEntries
            where bucketEntry.BucketId == bucketId && profile.Id == profileId
            select bucketEntry;
        
        return canAccessBucket.AnyAsync(cancellationToken);
    }

    public Task<bool> CanProfileAccessCloth(ProfileId profileId, ClothId clothId, CancellationToken cancellationToken = default)
    {
        var canAccessCloth =
            from profile in DbContext.Profiles
            from clothEntry in profile.ClothEntries
            where clothEntry.ClothId == clothId && profile.Id == profileId
            select clothEntry;
        
        return canAccessCloth.AnyAsync(cancellationToken);
    }
}