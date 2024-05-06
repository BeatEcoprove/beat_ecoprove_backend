using System.Reflection;

using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Models;

using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class DocumentRepository<TEntity, TId> : IRepository<TEntity, TId>
    where TEntity : Document<TId>
    where TId : DocumentId
{
    protected readonly IMongoCollection<TEntity> Collection;

    public DocumentRepository(IMongoDatabase database)
    {
        Collection = database.GetCollection<TEntity>(GetCollectionName());
    }

    private string GetCollectionName()
    {
        var entityCtor =
                typeof(TEntity)
                .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);

        if (entityCtor == null)
        {
            throw new ArgumentException("Could get any active constructor");
        }

        var entityInstance = entityCtor.Invoke(null) as TEntity;

        if (entityInstance is null)
        {
            throw new ArgumentException("Was not possible to instanciate the class");
        }

        var collectionNameProperty = typeof(TEntity)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .SingleOrDefault(property => property.Name == "CollectionName");

        if (collectionNameProperty is null)
        {
            throw new ArgumentException("There isn't any collection property");
        }

        var value = collectionNameProperty.GetValue(entityInstance) as string;
        return entityInstance.CollectionName;
    }

    [Obsolete]
    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await Collection.InsertOneAsync(entity, cancellationToken);
    }

    public async Task DeleteAsync(TId id, CancellationToken cancellationToken = default)
    {
        var filter = Builders<TEntity>.Filter.Eq("Id", id);

        await Collection.DeleteOneAsync(filter, cancellationToken: cancellationToken);
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
        var filter = Builders<TEntity>
            .Filter
            .Eq("UserId", entity.Id);

        await Collection
            .ReplaceOneAsync(filter, entity, cancellationToken: cancellationToken);
    }
}