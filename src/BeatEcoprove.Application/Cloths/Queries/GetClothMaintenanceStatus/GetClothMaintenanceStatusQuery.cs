using BeatEcoprove.Application.Cloths.Queries.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Queries.GetClothMaintenanceStatus;

public record GetClothMaintenanceStatusQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId
) : IQuery<ErrorOr<ClothMaintenanceStatus>>, IAuthorization;