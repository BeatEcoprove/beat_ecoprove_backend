using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

public class InviteNotification : Notification
{
    private InviteNotification(
        string title,
        GroupId groupId,
        ProfileId invitorId,
        ProfileId owner,
        string code
        ) 
        : base(title, owner)
    {
        GroupId = groupId;
        InvitorId = invitorId;
        Code = code;
    }

    public GroupId GroupId { get; private set; }
    public ProfileId InvitorId { get; private set; }
    public string Code { get; private set; } = null!;

    public static InviteNotification Create
    (
        string title,
        GroupId groupId,
        ProfileId invitorId,
        ProfileId ownerId,
        string code
    )
    {
        return new (
            title,
            groupId,
            invitorId,
            ownerId,
            code
        );
    }
}
