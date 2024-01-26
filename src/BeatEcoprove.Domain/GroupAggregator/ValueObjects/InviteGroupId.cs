using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class InviteGroupId : ValueObject
{
    private InviteGroupId()
    {
    }

    private InviteGroupId(Guid id) => Value = id;

    public Guid Value { get; private set; }

    public static InviteGroupId CreateUnique() => new(Guid.NewGuid());

    public static InviteGroupId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}