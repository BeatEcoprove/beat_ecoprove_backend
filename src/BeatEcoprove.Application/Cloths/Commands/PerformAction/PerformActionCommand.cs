using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;

using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Commands.PerformAction;

public record PerformActionCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId,
    Guid ServiceId,
    Guid ActionId
) : ICommand<ErrorOr<ClothResult>>, IAuthorization;