using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public record BorrowResult(
    string ClothAvatar,
    string Name,
    string Brand,
    string Color,
    string Size,
    string EcoScore
);

public class BorrowMessageResponse : TextMessageResponse
{
    public BorrowResult Borrow { get; set; }
    public bool IsAccepted { get; set; }

    public BorrowMessageResponse(
        string id,
        Guid groupId,
        ProfileResponse sender,
        string content,
        DateTimeOffset createdAt,
        BorrowResult borrow,
        bool isAccepted,
        string type)
        : base(id, groupId, sender, content, createdAt, type)
    {
        GroupId = groupId;
        Sender = sender;
        Content = content;
        CreatedAt = createdAt;
        Borrow = borrow;
        IsAccepted = isAccepted;
    }
}
