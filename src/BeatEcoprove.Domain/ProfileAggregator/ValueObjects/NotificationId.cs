using BeatEcoprove.Domain.Shared.Models;
using MongoDB.Bson;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class NotificationId : DocumentId
{
    private NotificationId() { }

    private NotificationId(ObjectId id) => Value = id;

    public override ObjectId Value { get; protected set; }

    public static NotificationId CreateUnique() => new(ObjectId.GenerateNewId());

    public static NotificationId Create(ObjectId id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator ObjectId(NotificationId id) => id.Value;
}
