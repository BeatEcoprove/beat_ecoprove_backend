using System.Text.Json.Serialization;

namespace BeatEcoprove.Application.Shared.Notifications;

public class LevelUpNotification
{
    [JsonPropertyName("id")] public string Id { get; init; } = null!;
    [JsonPropertyName("level")] public int Level { get; init; }
    [JsonPropertyName("xp")] public int Xp { get; init; }
}