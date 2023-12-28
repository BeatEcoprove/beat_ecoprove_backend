namespace BeatEcoprove.Contracts.Services;

/// <summary>
/// Maintenance Action, should be an list of actions of an Maintenance Service.
/// </summary>
/// <param name="Id"></param>
/// <param name="Title"></param>
/// <param name="Badge"></param>
public record MaintenanceAction
(
    Guid Id,
    string Title,
    string Badge
);