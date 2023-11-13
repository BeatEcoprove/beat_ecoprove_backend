namespace BeatEcoprove.Contracts.Profile;

public record ClothResponse
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