using BeatEcoprove.Domain.Shared.Models;
using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Serializers;

public class SerializersExtension
{
    public static void RegisterEntitySerializers()
    {
        var assembly = typeof(AggregateRootId<Guid>).Assembly;
        var documentIdType = typeof(AggregateRootId<Guid>);
        var derivedTypes = assembly.GetTypes()
                                   .Where(t => t != documentIdType && documentIdType.IsAssignableFrom(t));

        foreach (var derivedType in derivedTypes)
        {
            var serializerType = typeof(EntityIdGuidSerializer<>).MakeGenericType(derivedType);
            var serializer = Activator.CreateInstance(serializerType);
            BsonSerializer.RegisterSerializer(derivedType, serializer as IBsonSerializer);
        }
    }

    public static void RegisterDocumentSerializers()
    {
        var assembly = typeof(DocumentId).Assembly;
        var documentIdType = typeof(DocumentId);
        var derivedTypes = assembly.GetTypes()
                                   .Where(t => t != documentIdType && documentIdType.IsAssignableFrom(t));

        foreach (var derivedType in derivedTypes)
        {
            var serializerType = typeof(DocumentIdSerializer<>).MakeGenericType(derivedType);
            var serializer = Activator.CreateInstance(serializerType);
            BsonSerializer.RegisterSerializer(derivedType, serializer as IBsonSerializer);
        }
    }
}
