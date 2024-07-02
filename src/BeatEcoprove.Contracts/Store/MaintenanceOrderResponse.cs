namespace BeatEcoprove.Contracts.Store;

public record MaintenanceOrderResponse
(
    Guid Id,
    string Name,
    string Badge
);