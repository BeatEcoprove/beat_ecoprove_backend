using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Models;
using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class DocumentRepository<TEntity, TId> : IRepository<TEntity, TId>
    where TEntity : Document<TId>
    where TId : ValueObject
{
    protected readonly IMongoCollection<TEntity> Collection;

    public DocumentRepository(IMongoDatabase database)
    {
        var collectionName = typeof(TEntity).GetProperty("CollectionName")?.GetValue(null) as string;

        if (collectionName == null)
        {
            throw new ArgumentNullException(nameof(collectionName));
        }

        Collection = database.GetCollection<TEntity>(collectionName);
    }

    [Obsolete]
    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await Collection.InsertOneAsync(entity, cancellationToken);
    }

    public async Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default)
    {
        var filter = Builders<TEntity>.Filter.Eq("Id", id);

        return await Collection
            .Find(filter)
            .SingleOrDefaultAsync(cancellationToken);
    }

    public async Task UpdateByIdAsync(TId id, TEntity entity, CancellationToken cancellationToken = default)
    {
        var filter = Builders<TEntity>.Filter.Eq("Id", id);

        await Collection
            .UpdateOneAsync(filter, entity);
    }
}
