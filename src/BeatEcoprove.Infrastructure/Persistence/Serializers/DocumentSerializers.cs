using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace BeatEcoprove.Infrastructure.Persistence.Serializers;

public static class DocumentSerializers
{ 
    public static IServiceCollection RegisterSerializers(
        this IServiceCollection services,
        Type? searchType = null)
    {
        var serializerAssembly = searchType?.Assembly ?? typeof(DocumentSerializers).Assembly;
        var serializerType = typeof(SerializerBase<>);

        var serializers = serializerAssembly.GetTypes()
            .Where(type => IsSerializer(type, serializerType))
            .ToList();

        var serviceProvider = services.BuildServiceProvider();

        foreach (var serializer in serializers)
        {
            var constraint = serializer.GetGenericArguments()[0]
                .GetGenericParameterConstraints()[0];

            var derivedTypes = GetDerivedTypes(constraint);

            if (derivedTypes.Count() == 0)
            {
                continue;
            }

            foreach (var derivedType in derivedTypes)
            {
                var classWithGenericType = serializer.MakeGenericType(derivedType);
                var instance = Activator.CreateInstance(classWithGenericType);

                BsonSerializer.RegisterSerializer(derivedType, instance as IBsonSerializer);
            }
        }

        return services;
    }

    private static IEnumerable<Type> GetDerivedTypes(Type type)
    {
        return type.Assembly.GetTypes()
                    .Where(t => t != type && type.IsAssignableFrom(t));
    }

    private static bool IsSerializer(Type type, Type serializerType)
    {
        return type.IsSubclassOf(serializerType)
                    || (type.BaseType?.IsGenericType == true && type.BaseType.GetGenericTypeDefinition() == serializerType);
    }
}
