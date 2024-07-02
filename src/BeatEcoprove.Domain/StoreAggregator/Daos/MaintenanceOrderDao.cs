using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public record MaintenanceOrderDao(
    MaintenanceServiceId Id,
    string Title,
    string Badge);