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
    public BorrowClothResponse borrow { get; init; }

    public BorrowClothMessage(
        string id,
        string message,
        GroupId group,
        ChatMessageMember member,
        BorrowClothResponse borrow) : base(id, message, group, member)
    {
        this.borrow = borrow;
    }
}