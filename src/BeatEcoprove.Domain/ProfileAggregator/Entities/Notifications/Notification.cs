using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

public class Notification : Document<MessageId>
{
    protected Notification() { }

    protected Notification(
        string title,
        ProfileId owner
        )
    {
        Id = MessageId.CreateUnique();
        Title = title;
        Owner = owner;
    }

    public string Title { get; set; } = null!;
    public ProfileId Owner { get; set; } = null!;
    public virtual string Type { get; } = nameof(Notification);
    public override string CollectionName => "notifications";

    public void Remove()
    {
        DeletedAt = DateTimeOffset.Now;
    }
}