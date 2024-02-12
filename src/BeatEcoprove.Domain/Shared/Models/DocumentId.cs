using MongoDB.Bson;

namespace BeatEcoprove.Domain.Shared.Models;

public abstract class DocumentId : ValueObject
{
    public abstract ObjectId Value { get; protected set; }

    public static implicit operator ObjectId(DocumentId id) => id.Value;
}