using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers.ConnectToGroup;

public class ConnectToGroupMessage
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }
}
