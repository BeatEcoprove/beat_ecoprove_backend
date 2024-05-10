using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class Message : Document<MessageId>
{
    private Message() { }

    public Message(
        GroupId group,
        GroupMemberId sender,
        string title)
    {
        Id = MessageId.CreateUnique();
        Group = group;
        Sender = sender;
        Title = title;
    }

    public GroupId Group { get; protected set; } = null!;
    public GroupMemberId Sender { get; protected set; } = null!;
    public string Title { get; protected set; } = null!;
    // public new DateTimeOffset CreatedAt { get; private set; } = DateTimeOffset.UtcNow;
    public virtual string Type { get; } = nameof(Message);
    public override string CollectionName => "messages";
}