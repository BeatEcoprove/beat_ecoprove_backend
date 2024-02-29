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

    public GroupId GroupId { get; set; } = null!;
    public ProfileId InvitorId { get; set; } = null!;
    public string Code { get; set; } = null!;
    public override string Type => nameof(InviteNotification);

    public static InviteNotification Create
    (
        string title,
        GroupId groupId,
        ProfileId invitorId,
        ProfileId ownerId,
        string code
    )
    {
        return new(
            title,
            groupId,
            invitorId,
            ownerId,
            code
        );
    }
}