using System.Text.Json;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Notifications;

public class ServerChatTextMessage : SendNotification
{
    public ServerChatTextMessage(
        Guid groupId,
        Guid userId,
        string content)
    {
        GroupId = groupId;
        UserId = userId;
        Content = content;
    }

    public string Content { get; init; }
    public Guid GroupId { get; init; }
    public  Guid UserId { get; init; }

    public override string Type => SendNotificationType.ServerChatMessage.ToString();

    public override string ToString() => JsonSerializer.Serialize(this);

    public static implicit operator string(ServerChatTextMessage notification) => notification.ToString();
}