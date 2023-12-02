using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ClosetAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateCloth;

public record CreateClothCommand
(
    Guid AuthId,
    Guid? ProfileId,
    string Name,
    string GarmentType,
    string GarmentSize,
    string Brand,
    string Color,
    Stream ClothAvatar
) : ICommand<ErrorOr<Cloth>>;