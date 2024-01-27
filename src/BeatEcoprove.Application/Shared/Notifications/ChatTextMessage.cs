using System.Text.Json;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Notifications;

public class ChatTextMessage : SendNotification
{
    public ChatTextMessage(
        Guid groupId,
        string userName,
        string avatarPicture,
        string content)
    {
        GroupId = groupId;
        UserName = userName;
        AvatarPicture = avatarPicture;
        Content = content;
    }

    public string Content { get; init; }
    public Guid GroupId { get; init; }
    public string UserName { get; init; }
    public string AvatarPicture { get; init; }

    public override string Type => SendNotificationType.ChatTextMessage.ToString();

    public override string ToString() => JsonSerializer.Serialize(this);

    public static implicit operator string(ChatTextMessage notification) => notification.ToString();
}