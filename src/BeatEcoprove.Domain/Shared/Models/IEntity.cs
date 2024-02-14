namespace BeatEcoprove.Domain.Shared.Models;

public interface IEntity<TId>
    where TId : class
{
    public TId Id { get; }
}
