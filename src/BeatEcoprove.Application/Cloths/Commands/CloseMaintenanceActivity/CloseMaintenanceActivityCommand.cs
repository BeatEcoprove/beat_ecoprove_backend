using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Commands.CloseMaintenanceActivity;

public record CloseMaintenanceActivityCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId,
    Guid MaintenanceActivityId
) : ICommand<ErrorOr<ClothResult>>, IAuthorization;