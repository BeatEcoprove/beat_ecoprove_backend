using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public class TextMessageResponse
{
    public Guid GroupId { get; set; }
    public ProfileResponse Sender { get; set; }
    public string Content { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string Type { get; set; }

    public TextMessageResponse(
        Guid groupId,
        ProfileResponse sender,
        string content,
        DateTimeOffset createdAt,
        string type)
    {
        GroupId = groupId;
        Sender = sender;
        Content = content;
        CreatedAt = createdAt;
        Type = type;
    }
}