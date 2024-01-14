using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class TextMessage : Message<string>
{
    private TextMessage() {}

    public TextMessage(
        MessageId id, 
        GroupId group, 
        GroupMemberId sender, 
        string content) : base(id, group, sender, content)
    {
    }
}