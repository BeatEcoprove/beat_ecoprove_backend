using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ProfileRepository : Repository<Profile, ProfileId>, IProfileRepository
{
    public ProfileRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> DisableSubProfiles(AuthId authId, CancellationToken cancellationToken = default)
    {
        var getAllSubProfiles = from profile in DbContext.Set<Profile>()
            where profile.AuthId == authId
            select profile;

        var subProfiles = await getAllSubProfiles.ToListAsync(cancellationToken);

        if (subProfiles.Count == 0)
        {
            return false;
        }
        
        foreach (var profile in subProfiles)
        {
            DbContext.Profiles.Remove(profile);
        }

        return true;
    }

    public async Task<ProviderDao?> GetOrganizationAsync(ProfileId organizationId, CancellationToken cancellationToken = default)
    {
        var getOrganization = from profile in DbContext.Set<Profile>()
            let organization = profile as Organization
            where 
                organization != null && profile.Type.Equals(UserType.Organization)
            let totalRating = (
                from store in DbContext.Set<Store>()
                where 
                    store.Owner == organization.Id
                    group store by store.Owner into storeGroup
                    select new {
                        TotalRating = storeGroup.Sum(s => s.Ratings.Sum(r => r.Rate)),
                        TotalItems = storeGroup.Count()
                    }
            ).FirstOrDefault()
            select new ProviderDao(
                organization.Id,
                organization.UserName,
                organization.AvatarUrl,
                organization.TypeOption,
                new(),
                totalRating != null ? totalRating.TotalItems / totalRating.TotalItems : 0
            );

        return await getOrganization.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<List<Organization>> GetAllOrganizationsAsync(
        string? search = null, 
        int page = 1, 
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        var getAllOrganizations = from profile in DbContext.Set<Profile>()
            let organization = profile as Organization
            where
                profile.Type.Equals(UserType.Organization) && organization != null &&
                (search == null || ((string)profile.UserName).ToLower().Contains(search.ToLower()))
            select organization;
        
         getAllOrganizations = getAllOrganizations
            .Skip((page - 1) * pageSize)
            .Take(pageSize);
 
        return await getAllOrganizations.ToListAsync(cancellationToken);
    }

    public async Task<List<Profile>> GetAllProfilesAsync(string? search, int pageSize = 10, int page = 1,
        CancellationToken cancellationToken = default)
    {
        var getAllProfiles =
            from profile in DbContext.Profiles
            where
                (search == null || ((string)profile.UserName).ToLower().Contains(search.ToLower()))
            select profile;

        getAllProfiles = getAllProfiles
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await getAllProfiles
            .ToListAsync(cancellationToken);
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

    public async Task<List<ClothDao>> GetClosetCloth(
        Guid mainProfileId,
        List<ProfileId> queryProfiles,
        string? search,
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
                (colorValue == null || colorValue.Contains(color.Id)) &&
                (size == null || size.Contains(cloth.Size)) &&
                (category == null || category.Contains(cloth.Type)) &&
                (search == null || cloth.Name.ToLower().Contains(search) || brand.Name.ToLower().Contains(search))
            select mainProfileId != clothEntry.ProfileId ?
                new ClothDaoWithProfile(
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
            ) : new ClothDao(
                    cloth.Id,
                    cloth.Name,
                    cloth.Type.ToString(),
                    cloth.Size.ToString(),
                    brand.Name,
                    color.Hex,
                    cloth.EcoScore,
                    cloth.State.ToString(),
                    cloth.ClothAvatar);

        getAllCloth = getAllCloth
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await getAllCloth
            .ToListAsync(cancellationToken);
    }

    public Task<Profile?> GetByUserNameAsync(UserName username, CancellationToken cancellationToken)
    {
        return DbContext
            .Profiles
            .SingleOrDefaultAsync(p => p.UserName == username, cancellationToken);
    }

    public async Task UpdateWorkerProfileSustainablePoints(
        List<ProfileId> workerProfileIds, 
        int valueSustainablePoints,
        CancellationToken cancellationToken = default)
    {
        var getWorkers = from profile in DbContext.Set<Profile>()
            where profile.Type.Equals(UserType.Employee) && workerProfileIds.Contains(profile.Id)
            select profile;

        var workers = await getWorkers.ToListAsync(cancellationToken);
        workers.ForEach(worker =>
        {
            worker.SustainabilityPoints = valueSustainablePoints;
        });
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