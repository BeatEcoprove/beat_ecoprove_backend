using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Contracts;

internal class SendGroupTextMessageEventJson : WebSocketEventJson
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }

    [JsonPropertyName("message")]
    public string Message { get; init; } = string.Empty;
}