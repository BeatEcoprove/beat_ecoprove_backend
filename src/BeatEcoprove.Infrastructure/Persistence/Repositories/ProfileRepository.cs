﻿using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
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

    public async Task<List<Cloth>> GetClosetCloth(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        var getAllCloth =
            from profile in DbContext.Profiles
            from clothEntry in profile.ClothEntries
            join cloth in DbContext.Cloths on clothEntry.ClothId equals cloth.Id
            select cloth;

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
}