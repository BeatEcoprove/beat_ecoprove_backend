using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class BorrowMessage : Message
{
    public ClothId ClothId { get; init; } = null!;
    public bool IsAccepted { get; private set; } = false;

    public BorrowMessage(
        GroupId group,
        GroupMemberId sender,
        string title,
        ClothId clothId) : base(group, sender, title)
    {
        ClothId = clothId;
    }

    public void Accept()
    {
        IsAccepted = true;
    }

    public override string Type => nameof(BorrowMessage);
}