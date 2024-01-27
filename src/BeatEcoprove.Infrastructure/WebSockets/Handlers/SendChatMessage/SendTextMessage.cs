using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers.SendChatMessage;

public class SendTextMessage
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }
    
    [JsonPropertyName("message")]
    public string Message { get; init; } = string.Empty;
}