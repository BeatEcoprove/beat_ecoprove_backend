namespace BeatEcoprove.Domain.Shared.Models;

public interface IEntityId<TId>
{
    public abstract TId Value { get; }
}
