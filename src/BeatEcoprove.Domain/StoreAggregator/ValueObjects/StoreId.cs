using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.StoreAggregator.ValueObjects;

public class StoreId : AggregateRootId<Guid>
{
    private StoreId() { }

    private StoreId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static StoreId CreateUnique() => new(Guid.NewGuid());

    public static StoreId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(StoreId self) => self.Value;
}