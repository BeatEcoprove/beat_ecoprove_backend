using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

public class ColorId : AggregateRootId<Guid>
{
    private ColorId() { }

    private ColorId(Guid id) => Value = id;
    
    public sealed override Guid Value { get; protected set; }

    public static ColorId CreateUnique() => new(Guid.NewGuid());

    public static ColorId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(ColorId self) => self.Value;
}