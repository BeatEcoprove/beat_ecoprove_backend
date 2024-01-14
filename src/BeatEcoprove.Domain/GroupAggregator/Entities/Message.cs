using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public abstract class Message<T> : Entity<MessageId>
{
    protected Message() {  }
    
    protected Message(
        MessageId id,
        GroupId group,
        GroupMemberId sender,
        T content)
    {
        Id = id;
        Group = group;
        Sender = sender;
        Content = content;
        CreatedAt = DateTime.UtcNow;
    }
    
    public GroupId Group { get; protected set; }
    public GroupMemberId Sender { get; protected set; }
    public T Content { get; protected set; }
    public DateTime CreatedAt { get; private set; }
}