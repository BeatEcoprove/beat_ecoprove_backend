using MongoDB.Bson.Serialization.Attributes;

namespace BeatEcoprove.Domain.Shared.Models;

public abstract class Document<TId> : IEntity<TId>, IEquatable<Document<TId>>
    where TId : notnull, DocumentId
{
    public abstract string CollectionName { get; }

    public TId Id { get; protected set; } = null!;

    [BsonElement("created_at")]
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;

    [BsonElement("deleted_at")]
    public DateTimeOffset DeletedAt { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Document<TId> entity && Id.Equals(entity.Id);
    }

    public bool Equals(Document<TId>? other)
    {
        return Equals((object?)other);
    }

    public static bool operator ==(Document<TId>? left, Document<TId>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Document<TId>? left, Document<TId>? right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}