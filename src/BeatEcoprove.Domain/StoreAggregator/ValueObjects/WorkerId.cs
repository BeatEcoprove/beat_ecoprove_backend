using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.StoreAggregator.ValueObjects;

public class WorkerId : EntityId<Guid>
{
    private WorkerId() { }

    private WorkerId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static WorkerId CreateUnique() => new(Guid.NewGuid());

    public static WorkerId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(WorkerId self) => self.Value;
}