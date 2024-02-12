using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using MongoDB.Bson.Serialization.Attributes;

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

    [BsonElement("group_id")]
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    public GroupId GroupId { get; set; } = null!;

    [BsonElement("invitor_id")]
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    public ProfileId InvitorId { get; set; } = null!;

    [BsonElement("code")]
    [BsonRepresentation(MongoDB.Bson.BsonType.String)]
    public string Code { get; set; } = null!;

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
