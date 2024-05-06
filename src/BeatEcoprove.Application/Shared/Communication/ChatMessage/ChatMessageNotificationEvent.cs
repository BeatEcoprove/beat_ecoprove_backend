using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public class ChatMessageNotificationEvent<TContent> : NotificationEvent<TContent>
{
    public ChatMessageNotificationEvent
        (ProfileId to, TContent content)
        : base(to, content)
    {
    }

    public override string Type => nameof(TContent);
}