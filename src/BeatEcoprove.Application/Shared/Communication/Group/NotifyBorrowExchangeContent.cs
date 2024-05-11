
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.Group;

public class NotifyBorrowExchangeContent
{
    public NotifyBorrowExchangeContent(
        MessageId messageId,
        GroupId groupid,
        ClothId clothId,
        bool isAccepted)
    {
        MessageId = messageId.Value.ToString();
        ClothId = clothId;
        IsAccepted = isAccepted;
        GroupId = groupid;
    }

    public string MessageId { get; init; }
    public GroupId GroupId { get; init; }
    public ClothId ClothId { get; init; }
    public bool IsAccepted { get; init; }
}