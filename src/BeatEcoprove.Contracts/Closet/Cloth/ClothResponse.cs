
using System.Text.Json.Serialization;

using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Closet.Cloth;

public record ClothResponse(
    Guid Id,
    string Name,
    string Type,
    string Size,
    string Brand,
    string Color,
    int EcoScore,
    string ClothState,
    string ClothAvatar,
    ProfileClosetResponse Profile)
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ProfileClosetResponse Profile { get; private init; } = Profile;
}