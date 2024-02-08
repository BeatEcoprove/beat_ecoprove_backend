using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Contracts;

internal class ConnectGroupEventJson : WebSocketEventJson
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; set; }
}

