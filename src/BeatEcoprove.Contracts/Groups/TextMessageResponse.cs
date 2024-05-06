using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public class TextMessageResponse
{
    public Guid GroupId { get; set; }
    public ProfileResponse Sender { get; set; }
    public string Content { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public TextMessageResponse(Guid groupId, ProfileResponse sender, string content, DateTimeOffset createdAt)
    {
        GroupId = groupId;
        Sender = sender;
        Content = content;
        CreatedAt = createdAt;
    }
}