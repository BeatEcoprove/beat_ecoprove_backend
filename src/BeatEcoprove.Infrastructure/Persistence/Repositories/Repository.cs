using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public abstract class Repository<TEntity, TId>
    where TEntity : AggregateRoot<TId, Guid>
    where TId : AggregateRootId<Guid>
{
    protected readonly IApplicationDbContext _dbContext;

    protected Repository(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _dbContext
            .Set<TEntity>().AddAsync(entity, cancellationToken);
    }

    public async Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<TEntity>()
            .SingleOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public Task UpdateByIdAsync(TId id, TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
