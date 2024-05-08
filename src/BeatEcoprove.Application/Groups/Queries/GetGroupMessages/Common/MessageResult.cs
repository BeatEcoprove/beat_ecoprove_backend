using BeatEcoprove.Application.Shared.Communication.ChatMessage;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;

public class BorrowMessageResult : MessageResult
{
    public BorrowClothResponse Borrow { get; set; }
    public bool IsAccepted { get; set; }

    public BorrowMessageResult(
        string id,
        Guid groupId,
        Profile sender,
        string content,
        DateTimeOffset createdAt,
        BorrowClothResponse borrow,
        bool isAccepted
    ) : base(id, groupId, sender, content, createdAt)
    {
        Borrow = borrow;
        IsAccepted = isAccepted;
    }

    public override string Type => nameof(BorrowMessageResult);
}

public class MessageResult
{
    public MessageResult(string id, Guid groupId, Profile sender, string content, DateTimeOffset createdAt)
    {
        Id = id;
        GroupId = groupId;
        Sender = sender;
        Content = content;
        CreatedAt = createdAt;
    }
    public string Id { get; set; }
    public Guid GroupId { get; init; }
    public Profile Sender { get; init; }
    public string Content { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public virtual string Type { get; } = nameof(MessageResult);
}