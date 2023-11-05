using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.AuthAggregator.ValueObjects;

public class AuthId : AggregateRootId<Guid>
{
    private AuthId() { }

    private AuthId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static AuthId CreateUnique() => new(Guid.NewGuid());

    public static AuthId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(AuthId self) => self.Value;
}