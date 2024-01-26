using System.Text.Json;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Notifications;

public class InviteToGroupNotification : SendNotification
{
    public InviteToGroupNotification(
        string message, 
        string code,
        string groupId, 
        string invitorIdId)
    {
        Message = message;
        Code = code;
        GroupId = groupId;
        InvitorId = invitorIdId;
    }

    public string Message { get; init; }
    public string Code { get; init; }
    public string GroupId { get; init; }
    public string InvitorId { get; init; }

    public override string Type => SendNotificationType.InviteToGroup.ToString();

    public override string ToString() => JsonSerializer.Serialize(this);

    public static implicit operator string(InviteToGroupNotification notification) => notification.ToString();
}