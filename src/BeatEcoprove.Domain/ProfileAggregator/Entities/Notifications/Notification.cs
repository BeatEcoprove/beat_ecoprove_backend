using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

public abstract class Notification : Document<NotificationId>
{
    public override string CollectionName => "notifications";

    protected Notification(
        string title,
        ProfileId owner
        )
    {
        Id = NotificationId.CreateUnique(); 
        Title = title; 
        Owner = owner;
    }

    public string Title { get; private set; } = null!;
    public ProfileId Owner { get; private set; }
}
