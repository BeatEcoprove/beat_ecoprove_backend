namespace BeatEcoprove.Domain.Shared.Models;

public abstract class AggregateRootId<TId> : ValueObject
{
    public abstract TId Value { get; protected set; }

    public static implicit operator TId(AggregateRootId<TId> id) => id.Value;
}