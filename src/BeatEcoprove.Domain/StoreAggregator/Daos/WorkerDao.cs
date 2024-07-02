using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public record WorkerDao
(
    Guid Id,
    string Name,
    Email Email,
    WorkerType Type
);