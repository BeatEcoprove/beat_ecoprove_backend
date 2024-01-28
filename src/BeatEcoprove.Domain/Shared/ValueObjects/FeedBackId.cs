using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.Shared.ValueObjects;

public class FeedBackId : AggregateRootId<Guid>
{
    private FeedBackId() { }

    private FeedBackId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static FeedBackId CreateUnique() => new(Guid.NewGuid());

    public static FeedBackId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(FeedBackId self) => self.Value;
}