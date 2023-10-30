using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain;

public class GarmentId : AggregateRootId<Guid>
{
    private GarmentId() { }

    private GarmentId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static GarmentId CreateUnique() => new(Guid.NewGuid());

    public static GarmentId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(GarmentId self) => self.Value;
}