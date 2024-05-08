using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

public class InviteNotification : Notification
{
    private InviteNotification(
        string title,
        GroupId groupId,
        string groupName,
        ProfileId invitorId,
        ProfileId owner,
        string code
        )
        : base(title, owner)
    {
        GroupId = groupId;
        GroupName = groupName;
        InvitorId = invitorId;
        Code = code;
    }

    public GroupId GroupId { get; set; }
    public string GroupName { get; set; }
    public ProfileId InvitorId { get; set; }
    public string Code { get; set; }
    public override string Type => nameof(InviteNotification);

    public static InviteNotification Create
    (
        string title,
        GroupId groupId,
        string groupName,
        ProfileId invitorId,
        ProfileId ownerId,
        string code
    )
    {
        return new(
            title,
            groupId,
            groupName,
            invitorId,
            ownerId,
            code
        );
    }
}