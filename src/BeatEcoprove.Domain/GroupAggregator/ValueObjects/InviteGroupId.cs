using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class InviteGroupId : EntityId<Guid>
{
    private InviteGroupId()
    {
    }

    private InviteGroupId(Guid id) => Value = id;

    public override Guid Value { get; protected set; }

    public static InviteGroupId CreateUnique() => new(Guid.NewGuid());

    public static InviteGroupId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}