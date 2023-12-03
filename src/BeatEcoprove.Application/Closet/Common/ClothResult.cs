namespace BeatEcoprove.Application.Closet.Common;

public record ClothResult
(
    Guid Id,
    string Name,
    string Type,
    string Size,
    string Brand,
    string Color,
    int EcoScore,
    string ClothAvatar
);