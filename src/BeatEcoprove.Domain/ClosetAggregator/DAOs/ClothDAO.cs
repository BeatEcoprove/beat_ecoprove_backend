using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Domain.ClosetAggregator.DAOs;

public record ClothDao(
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