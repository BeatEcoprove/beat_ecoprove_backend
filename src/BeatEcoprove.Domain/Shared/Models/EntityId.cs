namespace BeatEcoprove.Domain.Shared.Models;

public abstract class EntityId<TId> : ValueObject, IEntityId<TId>
{
    public abstract TId Value { get; protected set; }

    public static implicit operator TId(EntityId<TId> id) => id.Value;
}