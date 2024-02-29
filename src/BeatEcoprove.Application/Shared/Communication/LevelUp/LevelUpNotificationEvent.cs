using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.LevelUp;

public class LevelUpNotificationEvent :
    NotificationEvent<LevelUpContent>, INotifer
{
    public LevelUpNotificationEvent
        (ProfileId to, LevelUpContent content) : base(to, content)
    {
    }

    public override string Type => nameof(LevelUpNotificationEvent);
    public Notification GetNotification()
    {
        return LeveUpNotification.Create(
            Owner,
            Content.Level,
            Content.Xp
        );
    }
}