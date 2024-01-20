using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
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

    public async Task<List<ClothDaoWithProfile>> GetClosetCloth(
        List<ProfileId> queryProfiles,
        List<ClothType>? category = null,
        List<ClothSize>? size = null,
        List<Guid>? colorValue = null,
        List<Guid>? brandValue = null,
        string? order = null,
        string? sortBy = null,
        int pageSize = 10,
        int page = 1,
        CancellationToken cancellationToken = default)
    {
        var getAllCloth =
            from profile in DbContext.Profiles
            from clothEntry in profile.ClothEntries
            from color in DbContext.Set<Color>()
            from brand in DbContext.Set<Brand>()
            join cloth in DbContext.Cloths on clothEntry.ClothId equals cloth.Id
            where 
                cloth.Color == color.Id && 
                cloth.Brand == brand.Id && 
                queryProfiles.Contains(profile.Id) &&
                (brandValue == null || brandValue.Contains(brand.Id)) &&
                (colorValue == null || colorValue.Contains(color.Id) ) &&
                (size == null || size.Contains(cloth.Size)) &&
                (category == null || category.Contains(cloth.Type))
            select new ClothDaoWithProfile(
                cloth.Id,
                cloth.Name,
                cloth.Type.ToString(),
                cloth.Size.ToString(),
                brand.Name,
                color.Hex,
                cloth.EcoScore,
                cloth.State.ToString(),
                cloth.ClothAvatar,
                profile
            );
    
        getAllCloth = getAllCloth
            .Skip((page - 1) * pageSize)
            .Take(pageSize);
            
        return await getAllCloth
            .ToListAsync(cancellationToken);
    }

    public Task<List<ProfileId>> GetNestedProfileIds(AuthId authId, CancellationToken cancellationToken)
    {
        var getNestedProfileIds =
            from auth in DbContext.Auths
            join profile in DbContext.Profiles on auth.Id equals profile.AuthId
            where auth.Id == authId
            select profile.Id;

        return getNestedProfileIds.ToListAsync(cancellationToken);
    }

    public async Task<List<Bucket>> GetBucketCloth(
        ProfileId profileId,
        List<Guid> clothIds,
        CancellationToken cancellationToken = default)
    {
        var getAllBuckets =
            from profile in DbContext.Profiles
            from bucketEntry in profile.BucketEntries
            from bucket in DbContext.Buckets
            from clothEntry in bucket.BucketClothEntries
            where 
                profile.Id == profileId && 
                bucketEntry.BucketId == bucket.Id &&
                clothEntry.BucketId == bucket.Id &&
                clothIds.Contains(clothEntry.ClothId) &&
                bucketEntry.DeletedAt == null &&
                clothEntry.DeletedAt == null
            select bucket;

        getAllBuckets = getAllBuckets.Distinct();
        return await getAllBuckets.ToListAsync(cancellationToken);
    }

    public Task<bool> CanProfileAccessBucket(ProfileId profileId, BucketId bucketId, CancellationToken cancellationToken = default)
    {
        var canAccessBucket =
            from profile in DbContext.Profiles
            from bucketEntry in profile.BucketEntries
            join auth in DbContext.Auths on profile.AuthId equals auth.Id
            where
                (bucketEntry.BucketId == bucketId && profile.Id == profileId)
                || (auth.MainProfileId == profileId)
            select bucketEntry;
        
        return canAccessBucket.AnyAsync(cancellationToken);
    }

    public Task<bool> CanProfileAccessCloth(ProfileId profileId, ClothId clothId, CancellationToken cancellationToken = default)
    {
        var canAccessCloth =
            from profile in DbContext.Profiles
            from clothEntry in profile.ClothEntries
            join auth in DbContext.Auths on profile.AuthId equals auth.Id
            where
                (clothEntry.ClothId == clothId && profile.Id == profileId)
                || (auth.MainProfileId == profileId)
            select clothEntry;
        
        return canAccessCloth.AnyAsync(cancellationToken);
    }

    public Task<List<ProfileDao>> GetAllProfilesOfAuthIdAsync(AuthId authId, CancellationToken cancellationToken)
    {
        var profiles =
            from auth in DbContext.Auths
            join profile in DbContext.Profiles on auth.Id equals profile.AuthId
            where auth.Id == authId
            select new ProfileDao(
                profile,
                auth.MainProfileId == profile.Id
            );

        return profiles.ToListAsync(cancellationToken);
    }

    public Task DeleteAsync(ProfileId id, CancellationToken cancellationToken)
    {
        var searchProfile =
            from profile in DbContext.Profiles
            where profile.Id == id
            select profile;


        return searchProfile.ExecuteDeleteAsync(cancellationToken);
    }
}