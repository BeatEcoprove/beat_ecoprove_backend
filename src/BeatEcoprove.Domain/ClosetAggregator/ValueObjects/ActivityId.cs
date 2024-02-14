using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

public class ActivityId : EntityId<Guid>
{
    private ActivityId() { }
    private ActivityId(Guid id) => Value = id;

    public override Guid Value { get; protected set; }
    public static ActivityId CreateUnique() => new(Guid.NewGuid());

    public static ActivityId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}