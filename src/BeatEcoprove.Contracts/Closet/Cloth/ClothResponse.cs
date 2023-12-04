namespace BeatEcoprove.Contracts.Closet.Cloth;

public record ClothResponse
(
    Guid Id,
    string Name,
    string Type,
    string Size,
    string Brand,
    string Color,
    int EcoScore,
    string ClothState,
    string ClothAvatar
);