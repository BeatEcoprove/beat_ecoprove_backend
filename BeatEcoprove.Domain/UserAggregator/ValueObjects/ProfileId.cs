using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class ProfileId : ValueObject
{
    private ProfileId() { }

    private ProfileId(Guid value) => Value = value;

    public Guid Value { get; private set; }

    public static ProfileId Create(Guid value) => new(value);

    public static ProfileId CreateUnique() => new(Guid.NewGuid());

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(ProfileId profileId) => profileId.Value;
}