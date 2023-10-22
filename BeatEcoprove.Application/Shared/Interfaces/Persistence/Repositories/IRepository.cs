using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IRepository<TEntity, in TId>
    where TEntity : AggregateRoot<TId, Guid>
    where TId : AggregateRootId<Guid>
{
    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
    Task<TEntity?> UpdateByIdAsync(TId id, TEntity entity, CancellationToken cancellationToken = default);
}