using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IClothRepository : IRepository<Cloth, ClothId>
{
    Task<List<Cloth>> GetClothOfProfile(ProfileId profileId, CancellationToken cancellationToken = default);
    Task<List<Cloth>> GetAllCloth(ProfileId currentProfile, CancellationToken cancellationToken);
    Task<bool> ClothExists(List<ClothId> cloths, CancellationToken cancellationToken = default);
}