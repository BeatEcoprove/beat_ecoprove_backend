using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class GroupMemberId : EntityId<Guid>
{
    private GroupMemberId() { }
    private GroupMemberId(Guid id) => Value = id;

    public override Guid Value { get; protected set; }

    public static GroupMemberId CreateUnique() => new(Guid.NewGuid());

    public static GroupMemberId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}