using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public class ChatMessageNotificationEvent<TContent> : NotificationEvent<TContent>
{
    private readonly string _type;

    public ChatMessageNotificationEvent
        (ProfileId to, TContent content, string type)
        : base(to, content)
    {
        this._type = type;
    }

    public override string Type => _type;
}