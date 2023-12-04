using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

public class ActivityId : ValueObject
{
    private ActivityId() { }
    private ActivityId(Guid id) => Value = id;

    public Guid Value { get; private set; }

    public static ActivityId CreateUnique() => new(Guid.NewGuid());

    public static ActivityId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}