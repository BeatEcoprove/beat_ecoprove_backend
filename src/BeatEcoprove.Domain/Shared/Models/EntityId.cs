namespace BeatEcoprove.Domain.Shared.Models;

public interface IEntityId<TId>
{
    public abstract TId Value { get; }
}

public abstract class EntityId<TId> : ValueObject
{
    public abstract TId Value { get; protected set; }

    public static implicit operator TId(EntityId<TId> id) => id.Value;
}