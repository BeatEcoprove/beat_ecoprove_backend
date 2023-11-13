using ErrorOr;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Profiles.Commands.AddClothToCloset;

public record AddClothToProfileCommand
(
    Guid Profile,
    string Email,
    string Name,
    string GarmentType,
    string GarmentSize,
    string Brand,
    string Color,
    Stream ClothAvatar
) : ICommand<ErrorOr<Cloth>>;