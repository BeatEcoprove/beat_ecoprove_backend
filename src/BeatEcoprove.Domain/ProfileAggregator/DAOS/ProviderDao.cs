using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Daos;

namespace BeatEcoprove.Domain.ProfileAggregator.DAOS;

public record ProviderDao
(
    ProfileId ProviderId,
    string Title,
    string Picture,
    TypeOption Type,
    List<MaintenanceOrderDao> Services,
    double TotalRanking
);