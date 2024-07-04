using BeatEcoprove.Contracts.Store;

namespace BeatEcoprove.Contracts.Providers;

public record ProviderResponse
(
    Guid Id,
    string Title,
    string Picture,
    string Type,
    List<MaintenanceOrderResponse> services,
    double TotalRanking
);