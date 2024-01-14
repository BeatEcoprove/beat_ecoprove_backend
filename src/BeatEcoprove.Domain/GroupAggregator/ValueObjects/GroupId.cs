using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class GroupId : AggregateRootId<Guid>
{
    private GroupId() { }

    private GroupId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static GroupId CreateUnique() => new(Guid.NewGuid());

    public static GroupId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(GroupId self) => self.Value;
}