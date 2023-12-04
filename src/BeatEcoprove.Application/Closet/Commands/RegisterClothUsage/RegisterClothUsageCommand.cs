using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RegisterClothUsage;

public record RegisterClothUsageCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId
) : ICommand<ErrorOr<DailyUseActivity>>, IAuthorization;