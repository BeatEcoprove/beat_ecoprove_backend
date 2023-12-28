namespace BeatEcoprove.Contracts.Services;

public record MaintenanceServiceResponse
(
    Guid Id,
    string Title,
    string Badge,
    string Description,
    List<MaintenanceAction> Actions, // TODO: Map Endpoint to Service Action to persist data
    bool IsBeingUsed // Is this this service selected?
);