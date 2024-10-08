﻿using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IProfileRepository : IRepository<Profile, ProfileId>
{
    Task<bool> DisableSubProfiles(
        AuthId authId,
        CancellationToken cancellationToken = default);
    Task<ProviderDao?> GetOrganizationAsync(
        ProfileId organizationId,
        CancellationToken cancellationToken = default);
    Task<List<Organization>> GetAllOrganizationsAsync(
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default
    );
    Task<List<Profile>> GetAllProfilesAsync(string? search,
        int pageSize = 10,
        int page = 1,
        CancellationToken cancellationToken = default);
    Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken = default);
    Task<Profile?> GetProfileByAuthId(AuthId id, CancellationToken cancellationToken = default);
    Task<bool> CanProfileAccessBucket(ProfileId profileId, BucketId bucketId, CancellationToken cancellationToken = default);
    Task<bool> CanProfileAccessCloth(ProfileId profileId, ClothId clothId, CancellationToken cancellationToken = default);
    Task<List<ProfileDao>> GetAllProfilesOfAuthIdAsync(AuthId authId, CancellationToken cancellationToken);
    Task DeleteAsync(ProfileId id, CancellationToken cancellationToken);
    Task<List<ProfileId>> GetNestedProfileIds(AuthId authId, CancellationToken cancellationToken);
    Task<List<Bucket>> GetBucketCloth(ProfileId profileId, List<Guid> clothIds, CancellationToken cancellationToken = default);
    Task<List<ClothDao>> GetClosetCloth(
        Guid mainProfileId,
        List<ProfileId> profileId,
        string? search,
        List<ClothType>? category = null,
        List<ClothSize>? size = null,
        List<Guid>? color = null,
        List<Guid>? brand = null,
        string? order = null,
        string? sortBy = null,
        int pageSize = 10,
        int page = 1,
        CancellationToken cancellationToken = default);
    Task<Profile?> GetByUserNameAsync(
        UserName username, 
        CancellationToken cancellationToken = default);
    Task UpdateWorkerProfileSustainablePoints(
        List<ProfileId> workerProfileIds, 
        int valueSustainablePoints, 
        CancellationToken cancellationToken = default);
}