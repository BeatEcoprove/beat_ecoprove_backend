﻿using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IBucketRepository : IRepository<Bucket, BucketId>
{
    Task<Bucket?> GetByIdWithClothAsync(BucketId bucketId, CancellationToken cancellationToken);
    Task<bool> IsBucketNameAlreadyUsed(ProfileId profileId, BucketId bucketId, string name, CancellationToken cancellationToken = default);
    Task<bool> AreClothAlreadyOnBucket(List<ClothId> clothIds, CancellationToken cancellationToken = default);
    Task<List<ClothDao>> GetClothsAsync(BucketId bucketId, CancellationToken cancellationToken = default);
    Task<(bool, Bucket)> CheckIfClothBelongsToAnBucket(ClothId clothId, CancellationToken cancellationToken = default);
    Task RemoveByIdAsync(BucketId bucketId, CancellationToken cancellationToken);
}