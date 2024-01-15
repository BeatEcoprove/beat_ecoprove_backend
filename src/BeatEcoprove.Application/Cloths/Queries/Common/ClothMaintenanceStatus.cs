using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Domain.ClosetAggregator.Entities;

namespace BeatEcoprove.Application.Cloths.Queries.Common;

public record ClothMaintenanceStatus
(
    ClothResult Cloth,
    MaintenanceService Service,
    MaintenanceAction Action,
    Guid MaintenanceActivityId,
    string Status
);