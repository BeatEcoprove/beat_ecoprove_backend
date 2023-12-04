using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;

using BeatEcoprove.Domain.ClosetAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateCloth;

public record CreateClothCommand
(
    Guid AuthId,
    Guid ProfileId,
    string Name,
    string ClothType,
    string ClothSize,
    string Brand,
    string Color,
    Stream ClothAvatar
) : ICommand<ErrorOr<ClothResult>>, IAuthorization;
