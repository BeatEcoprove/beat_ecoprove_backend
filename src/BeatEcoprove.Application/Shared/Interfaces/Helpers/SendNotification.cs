using System.Text.Json;

namespace BeatEcoprove.Application.Shared.Interfaces.Helpers;

public enum SendNotificationType
{
    LevelUp,
    InviteToGroup
}

public abstract class SendNotification
{
    public abstract string Type { get; }
    public override string ToString() => JsonSerializer.Serialize(this);
    public static implicit operator string(SendNotification notification) => notification.ToString();
}