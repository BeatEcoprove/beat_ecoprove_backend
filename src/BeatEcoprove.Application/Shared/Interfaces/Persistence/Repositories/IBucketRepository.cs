using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IBucketRepository : IRepository<Bucket, BucketId>
{ 
    Task<bool> CanAddClothsAsync(List<ClothId> clothIds, CancellationToken cancellationToken);
    Task<List<ClothDao>> GetClothsAsync(BucketId bucketId, CancellationToken cancellationToken);
}