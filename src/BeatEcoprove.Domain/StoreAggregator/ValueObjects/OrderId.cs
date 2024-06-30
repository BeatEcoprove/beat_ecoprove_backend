using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.StoreAggregator.ValueObjects;

public class OrderId : EntityId<Guid>
{
    private OrderId() { }

    private OrderId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static OrderId CreateUnique() => new(Guid.NewGuid());

    public static OrderId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(OrderId self) => self.Value;
}