namespace BeatEcoprove.Contracts.Profile;

public record ClothResponse
(
    string Name,
    string Type,
    string Size,
    string Brand,
    string Color,
    int EcoScore,
    string ClothAvatar
);