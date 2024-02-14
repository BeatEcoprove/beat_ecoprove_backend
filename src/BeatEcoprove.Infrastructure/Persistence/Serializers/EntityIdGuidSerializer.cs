using BeatEcoprove.Domain.Shared.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System.Reflection;

namespace BeatEcoprove.Infrastructure.Persistence.Serializers;

public class EntityIdGuidSerializer<TId> : SerializerBase<TId>
    where TId : class, IEntityId<Guid>
{
    public override TId Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
    {
        var bsonReader = context.Reader;
        var binaryData = bsonReader.ReadBinaryData();
        var byteArray = binaryData.Bytes;

        var guid = new Guid(byteArray);

        var stronglyTypedIdCtor = typeof(TId)
            .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(Guid) }, null);

        if (stronglyTypedIdCtor is null)
        {
            throw new ArgumentNullException(nameof(stronglyTypedIdCtor));
        }

        var id = stronglyTypedIdCtor.Invoke(new object[] { guid }) as TId;

        if (id is null)
        {
            throw new ArgumentNullException(nameof(id));
        }

        return id;
    }

    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, TId value)
    {
        var bsonWriter = context.Writer;
        var guidBytes = value.Value.ToByteArray();
        var binaryData = new BsonBinaryData(guidBytes);
        bsonWriter.WriteBinaryData(binaryData);
    }
}
