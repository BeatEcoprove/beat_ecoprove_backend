using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public class GroupMemberId : ValueObject
{
    private GroupMemberId() { }
    private GroupMemberId(Guid id) => Value = id;

    public Guid Value { get; private set; }

    public static GroupMemberId CreateUnique() => new(Guid.NewGuid());

    public static GroupMemberId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}