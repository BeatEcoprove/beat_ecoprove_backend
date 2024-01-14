namespace BeatEcoprove.Contracts.Services;

public record MaintenanceServiceResponse
(
    Guid Id,
    string Title,
    string Badge,
    string Description,
    List<MaintenanceActionResponse> Actions
);