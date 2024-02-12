using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using System.Text.Json;

namespace BeatEcoprove.Application.Shared.Interfaces.Helpers;

public enum SendNotificationType
{
    LevelUp,
    InviteToGroup,
    ServerChatMessage,
    ChatTextMessage,
    SimpleMessage
}

public abstract class SendNotification
{
    public SendNotification(Notification notication)
    {
        Notification = notication;
    }
    
    public Notification Notification { get; init; }
    public abstract string Type { get; }
    public override string ToString() => JsonSerializer.Serialize(this);
    public static implicit operator string(SendNotification notification) => notification.ToString();
}