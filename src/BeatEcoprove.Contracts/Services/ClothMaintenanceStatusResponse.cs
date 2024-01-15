using BeatEcoprove.Contracts.Profile;
using ClothResponse = BeatEcoprove.Contracts.Closet.Cloth.ClothResponse;

namespace BeatEcoprove.Contracts.Services;

public record ClothMaintenanceStatusResponse
(
    ClothResponse Cloth,
    MaintenanceSelectorResponse Service,
    Guid MaintenanceActivityId,
    string Status
);