using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.Group;

public record EnterOnGroupContent
(
    GroupId Group,
    string Message
);

public class EnterOnGroupNotificationEvent 
    : NotificationEvent<EnterOnGroupContent>
{
    public EnterOnGroupNotificationEvent
        (ProfileId owner, EnterOnGroupContent content) : base(owner, content)
    {
    }

    public override string Type => nameof(EnterOnGroupNotificationEvent);
}
