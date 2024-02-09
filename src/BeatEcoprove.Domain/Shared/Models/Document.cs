using MongoDB.Bson;

namespace BeatEcoprove.Domain.Shared.Models;

public abstract class Document<TId> : BsonDocument, IEntity<TId>, IEquatable<Document<TId>>
    where TId : notnull, ValueObject
{
    public abstract string CollectionName { get; }

    public TId Id { get; protected set; }

    public override bool Equals(object? obj)
    {
        return obj is Document<TId> entity && Id.Equals(entity.Id);
    }

    public bool Equals(Document<TId>? other)
    {
        return Equals((object?)other);
    }

    public static bool operator ==(Document<TId> left, Document<TId> right)
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
