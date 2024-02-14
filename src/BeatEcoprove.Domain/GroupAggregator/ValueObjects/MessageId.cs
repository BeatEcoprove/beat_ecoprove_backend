using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using MongoDB.Bson;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class MessageId : DocumentId
{
    private MessageId() { }

    private MessageId(ObjectId id) => Value = id;

    public override ObjectId Value { get; protected set; }

    public static MessageId CreateUnique() => new(ObjectId.GenerateNewId());

    public static MessageId Create(ObjectId id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator ObjectId(MessageId id) => id.Value;
}