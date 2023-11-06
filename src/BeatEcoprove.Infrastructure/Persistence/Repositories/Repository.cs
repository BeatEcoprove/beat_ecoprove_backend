using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public abstract class Repository<TEntity, TId>
    where TEntity : AggregateRoot<TId, Guid>
    where TId : AggregateRootId<Guid>
{
    protected readonly IApplicationDbContext DbContext;

    protected Repository(IApplicationDbContext dbContext)
    {
        this.DbContext = dbContext;
    }

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await DbContext
            .Set<TEntity>().AddAsync(entity, cancellationToken);
    }

    public async Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<TEntity>()
            .SingleOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public Task UpdateByIdAsync(TId id, TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
