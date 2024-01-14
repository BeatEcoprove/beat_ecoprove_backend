using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class MessageId : ValueObject
{
    private MessageId() { }
    private MessageId(Guid id) => Value = id;

    public Guid Value { get; private set; }

    public static MessageId CreateUnique() => new(Guid.NewGuid());

    public static MessageId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}