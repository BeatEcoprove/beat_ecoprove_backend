using MongoDB.Bson;

namespace BeatEcoprove.Domain.Documents;

public record Notification(
    Guid UserId,
    string Title,
    Guid GroupId,
    Guid InvitorId,
    string Code
)
{
    public ObjectId Id = ObjectId.GenerateNewId();
};