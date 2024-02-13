using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

public class Notification : Document<NotificationId>
{
    protected Notification() { }

    protected Notification(
        string title,
        ProfileId owner
        )
    {
        Id = NotificationId.CreateUnique();
        Title = title;
        Owner = owner;
    }

    public string Title { get; set; } = null!;
    public ProfileId Owner { get; set; } = null!;
    public override string CollectionName => "notifications";
}
