using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IProfileRepository : IRepository<Profile, ProfileId>
{
    Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken = default);
    Task<Profile?> GetProfileByAuthId(AuthId id, CancellationToken cancellationToken = default);
    Task<List<ClothDao>> GetClosetCloth(ProfileId profileId, CancellationToken cancellationToken = default);
    Task<List<Bucket>> GetBucketCloth(ProfileId profileId, CancellationToken cancellationToken = default);
    Task<bool> CanProfileAccessBucket(ProfileId profileId, BucketId bucketId, CancellationToken cancellationToken = default);
}