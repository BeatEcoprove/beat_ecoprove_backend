using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using System.Text.Json;

namespace BeatEcoprove.Application.Shared.Notifications;

public class SimpleMessage : SendNotification
{
    public SimpleMessage(string message)
    {
        Message = message;
    }

    public string Message { get; init; }
    public override string Type => SendNotificationType.SimpleMessage.ToString();

    public override string ToString() => JsonSerializer.Serialize(this);

    public static implicit operator string(SimpleMessage notification) => notification.ToString();
}
