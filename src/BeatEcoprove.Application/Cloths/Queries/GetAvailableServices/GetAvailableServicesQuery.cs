using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Queries.GetAvailableServices;

public record GetAvailableServicesQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId
) : IQuery<ErrorOr<List<MaintenanceService>>>, IAuthorization;