using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IClothRepository : IRepository<Cloth, ClothId>
{
    Task<bool> ClothExists(List<ClothId> cloths, CancellationToken cancellationToken = default);
    Task<ClothDao?> GetClothDaoByIdAsync(ClothId id, bool withDeleted = false, CancellationToken cancellationToken = default);
    Task<ClothDao?> GetClothDaoByIdWithNoFiltersAsync(ClothId id, bool withDeleted = false, CancellationToken cancellationToken = default);
    Task RemoveByIdAsync(ClothId clothId, CancellationToken cancellationToken);
    Task<List<MaintenanceService>> GetAvailableMaintenanceServices(ClothId id, CancellationToken cancellationToken);
    Task<MaintenanceActivity?> GetLatestMaintenanceActivity(ClothId id, CancellationToken cancellationToken);
    Task<List<Bucket>> GetBuckets(ClothId id, CancellationToken cancellationToken);
    Task<bool> ChangeClothState(ClothId id, ClothState state, CancellationToken cancellationToken = default);
    Task<List<Activity>> GetHistoryOfActivities(ClothId clothId, CancellationToken cancellationToken = default);
}