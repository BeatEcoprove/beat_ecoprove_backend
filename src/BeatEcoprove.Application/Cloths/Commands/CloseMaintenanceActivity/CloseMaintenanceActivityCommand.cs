using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Domain.ClosetAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Commands.CloseMaintenanceActivity;

public record CloseMaintenanceActivityCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId,
    Guid MaintenanceActivityId
) : ICommand<ErrorOr<Cloth>>, IAuthorization;