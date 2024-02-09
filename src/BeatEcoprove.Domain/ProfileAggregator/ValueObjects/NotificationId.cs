using BeatEcoprove.Domain.Shared.Models;
using MongoDB.Bson;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class NotificationId : ValueObject
{
    private NotificationId() { }

    private NotificationId(ObjectId id) => Value = id;

    public ObjectId Value { get; private set; }

    public static NotificationId CreateUnique() => new(ObjectId.GenerateNewId());

    public static NotificationId Create(ObjectId id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator ObjectId(NotificationId id) => id.Value;
}
