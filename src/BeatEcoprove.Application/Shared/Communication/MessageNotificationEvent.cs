using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication;

public class MessageNotificationEvent : NotificationEvent<string>
{
    public MessageNotificationEvent
        (ProfileId owner, string content) : base(owner, content)
    {
    }

    public override string Type => nameof(MessageNotificationEvent);
}
