using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class BucketId : ValueObject
{

    private BucketId() { }

    private BucketId(Guid id) => Value = id;
    public  Guid Value { get; private set; }

    public static BucketId CreateUnique() => new(Guid.NewGuid());

    public static BucketId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(BucketId self) => self.Value;
}
