using System.Net.WebSockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets;

public enum WbSocketType
{
    Auth
}

public class WebSocketMessage
{
    public class TypeMessage
    {
        [JsonPropertyName("type")]
        public required string Type { get; init; } 
    }
    
    public WebSocketMessage(WebSocket socket, Guid userId, string jsonContent)
    {
        var decodedType = JsonSerializer.Deserialize<TypeMessage>(jsonContent)!;
            
        Socket = socket;
        UserId = userId;
        JsonContent = jsonContent;
        Type = decodedType.Type switch
        {
            "auth" => WbSocketType.Auth,
            _ => throw new ArgumentException("Unknown message type")
        };
    }

    public WebSocket Socket { get; init; }
    public Guid UserId { get; init; }
    private string JsonContent { get; init; }
    public WbSocketType Type { get; init; }
    
    public T? GetContent<T>()
    {
        return JsonSerializer.Deserialize<T>(JsonContent);
    }
}
