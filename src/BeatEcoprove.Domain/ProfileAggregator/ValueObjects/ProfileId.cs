using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class ProfileId : AggregateRootId<Guid>
{
    private ProfileId() { }

    private ProfileId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static ProfileId CreateUnique() => new(Guid.NewGuid());

    public static ProfileId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(ProfileId self) => self.Value;
}