namespace BeatEcoprove.Contracts.Services;

public record MaintenanceSelectorResponse
(
    Guid Id,
    string Title,
    string Badge,
    string Description,
    MaintenanceActionResponse RunningAction
);

public record MaintenanceServiceResponse
(
    Guid Id,
    string Title,
    string Badge,
    string Description,
    List<MaintenanceActionResponse> Actions
);