using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public record BorrowClothResponse
(
    string Avatar,
    string Title,
    string Brand,
    string Color,
    string Size,
    string EcoScore
);

public class BorrowClothMessage : TextMessage
{
    public BorrowClothResponse Borrow { get; init; }
    public bool IsAccepted { get; init; }

    public BorrowClothMessage(
        string id,
        string message,
        GroupId group,
        ChatMessageMember member,
        BorrowClothResponse borrow,
        bool isAccepted) : base(id, message, group, member)
    {
        Borrow = borrow;
        IsAccepted = isAccepted;
    }
}