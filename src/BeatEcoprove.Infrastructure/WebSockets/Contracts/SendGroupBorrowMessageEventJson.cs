using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Contracts;

public class SendGroupBorrowMessageEventJson : WebSocketEventJson
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }
    
    [JsonPropertyName("clothId")]
    public Guid ClothId { get; init; }

    [JsonPropertyName("message")]
    public string Message { get; init; } = string.Empty;
}