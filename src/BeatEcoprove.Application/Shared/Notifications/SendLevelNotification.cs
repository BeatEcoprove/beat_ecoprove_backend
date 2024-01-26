using System.Text.Json;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Notifications;

public class SendLevelNotification : SendNotification
{
    public SendLevelNotification(string id, int level)
    {
        Id = id;
        Level = level;
    }

    public string Id { get; init; }
    public int Level { get; init; }

    public override string Type => SendNotificationType.LevelUp.ToString();
    
    public override string ToString() => JsonSerializer.Serialize(this);
    
    public static implicit operator string(SendLevelNotification notification) => notification.ToString();
}