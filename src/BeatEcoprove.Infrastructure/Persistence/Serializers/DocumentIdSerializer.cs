using System.Reflection;

using BeatEcoprove.Domain.Shared.Models;

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace BeatEcoprove.Infrastructure.Persistence.Serializers;

public class DocumentIdSerializer<TId> : SerializerBase<TId>
    where TId : DocumentId
{
    public override TId Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
    {
        var bsonReader = context.Reader;
        var objectId = bsonReader.ReadObjectId();

        var stronglyTypedIdCtor = typeof(TId)
            .GetConstructor(
                BindingFlags.NonPublic | BindingFlags.Instance,
                null,
                new[] { typeof(ObjectId) },
                null
            );

        if (stronglyTypedIdCtor is null)
        {
            throw new ArgumentNullException(nameof(stronglyTypedIdCtor));
        }

        var id = stronglyTypedIdCtor.Invoke(new object[] { objectId }) as TId;

        if (id is null)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return id;
    }

    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, TId value)
    {
        var bsonWriter = context.Writer;
        bsonWriter.WriteObjectId(value.Value);
    }
}