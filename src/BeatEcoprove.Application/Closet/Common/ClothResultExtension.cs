using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Closet.Common;

public record ClothResultExtension
(
    Guid Id,
    string Name,
    string Type,
    string Size,
    string Brand,
    string Color,
    int EcoScore,
    string ClothState,
    string ClothAvatar,
    Profile Profile
) : IClothResult;