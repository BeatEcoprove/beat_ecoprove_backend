using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.Shared.ValueObjects;

public class BrandId : AggregateRootId<Guid>
{
    private BrandId() { }

    private BrandId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static BrandId CreateUnique() => new(Guid.NewGuid());

    public static BrandId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(BrandId self) => self.Value;
}