using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IClothRepository : IRepository<Cloth, ClothId>
{
    Task<bool> ClothExists(List<ClothId> cloths, CancellationToken cancellationToken = default);
    new Task<ClothDao?> GetClothDaoByIdAsync(ClothId id, CancellationToken cancellationToken = default);
    Task RemoveByIdAsync(ClothId clothId, CancellationToken cancellationToken);
    Task<List<MaintenanceService>> GetAvailableMaintenanceServices(ClothId id, CancellationToken cancellationToken);
}