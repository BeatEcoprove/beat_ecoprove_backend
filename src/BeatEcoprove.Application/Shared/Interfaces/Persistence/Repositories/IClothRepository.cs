using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IClothRepository : IRepository<Cloth, ClothId>
{
    Task<List<Cloth>> GetAllClothAndBuckets(ProfileId profileId, CancellationToken cancellationToken = default);
}