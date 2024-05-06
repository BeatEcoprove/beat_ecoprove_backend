using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class BorrowMessage : Message
{
    public ClothId ClothId { get; init; } = null!;

    public BorrowMessage(
        GroupId group,
        GroupMemberId sender,
        string title,
        ClothId clothId) : base(group, sender, title)
    {
        ClothId = clothId;
    }

    public override string Type => nameof(BorrowMessage);
}