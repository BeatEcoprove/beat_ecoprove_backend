using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

public class ClothId : AggregateRootId<Guid>
{

    private ClothId() { }

    private ClothId(Guid id) => Value = id;
    public sealed override Guid Value { get; protected set; }

    public static ClothId CreateUnique() => new(Guid.NewGuid());

    public static ClothId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(ClothId self) => self.Value;
}
