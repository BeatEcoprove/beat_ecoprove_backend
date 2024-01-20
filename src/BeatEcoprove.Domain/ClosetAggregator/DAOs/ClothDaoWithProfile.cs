using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Domain.ClosetAggregator.DAOs;

public record ClothDaoWithProfile
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
) : ClothDao
    (
    Id,
    Name,
    Type,
    Size,
    Brand,
    Color,
    EcoScore,
    ClothState,
    ClothAvatar
);