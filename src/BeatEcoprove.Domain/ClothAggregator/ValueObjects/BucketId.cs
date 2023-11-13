using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClothAggregator.ValueObjects;

public class BucketId : AggregateRootId<Guid>
{

    private BucketId() { }

    private BucketId(Guid id) => Value = id;
    public sealed override Guid Value { get; protected set; }

    public static BucketId CreateUnique() => new(Guid.NewGuid());

    public static BucketId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(BucketId self) => self.Value;
}
