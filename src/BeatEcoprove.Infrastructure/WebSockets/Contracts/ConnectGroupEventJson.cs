using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Contracts;

internal class ConnectGroupEventJson : WebSocketEventJson
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}

