using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class TextMessage : Message<string>
{
    private TextMessage() {}

    public TextMessage(
        GroupId group, 
        GroupMemberId sender, 
        string content
    ) : base(MessageId.CreateUnique(), group, sender, content)
    {
    }
}