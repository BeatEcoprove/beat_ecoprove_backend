using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IRepository<TEntity, in TId>
    where TEntity : IEntity<TId>
    where TId : ValueObject
{
    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
    Task UpdateByIdAsync(TId id, TEntity entity, CancellationToken cancellationToken = default);
}