using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Shared;

public interface IDocumentTypeConfiguration<TEntity>
    where TEntity : class
{
    void Configure(BsonClassMap<TEntity> map);
}