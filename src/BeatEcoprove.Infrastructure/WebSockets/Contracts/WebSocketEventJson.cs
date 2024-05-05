using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Contracts;

public class WebSocketEventJson
{
    [JsonPropertyName("type")]
    public string Type { get; init; } = null!;
}