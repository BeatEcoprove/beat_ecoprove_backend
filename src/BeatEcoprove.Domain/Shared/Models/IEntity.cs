namespace BeatEcoprove.Domain.Shared.Models;

public interface IEntity<TId>
    where TId : notnull, ValueObject
{
    TId Id { get; }
}
