using BeatEcoprove.Application.Shared.Communication.ChatMessage;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;

public class BorrowMessageResult : MessageResult
{
    public BorrowClothResponse Borrow { get; set; }
    public BorrowMessageResult(
        Guid groupId,
        Profile sender,
        string content,
        DateTimeOffset createdAt,
        BorrowClothResponse borrow
    ) : base(groupId, sender, content, createdAt)
    {
        Borrow = borrow;
    }

    public override string Type => nameof(BorrowMessageResult);
}

public class MessageResult
{
    public MessageResult(Guid groupId, Profile sender, string content, DateTimeOffset createdAt)
    {
        GroupId = groupId;
        Sender = sender;
        Content = content;
        CreatedAt = createdAt;
    }

    public Guid GroupId { get; init; }
    public Profile Sender { get; init; }
    public string Content { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public virtual string Type { get; } = nameof(MessageResult);
}