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

    public BorrowMessageResponse(
        Guid groupId,
        ProfileResponse sender,
        string content,
        DateTimeOffset createdAt,
        BorrowResult borrow,
        string type)
        : base(groupId, sender, content, createdAt, type)
    {
        GroupId = groupId;
        Sender = sender;
        Content = content;
        CreatedAt = createdAt;
        Borrow = borrow;
    }
}
