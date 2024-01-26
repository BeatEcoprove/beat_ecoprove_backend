using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Notifications;

public class LevelUpNotification
{
    [JsonPropertyName("id")] public string Id { get; init; } = null!;
    [JsonPropertyName("level")] public int Level { get; init; }
    [JsonPropertyName("xp")] public int Xp { get; init; }
}