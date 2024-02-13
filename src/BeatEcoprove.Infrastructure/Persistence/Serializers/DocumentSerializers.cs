using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Serializers;

public static class DocumentSerializers
{ 
    public static IServiceCollection RegisterSerializers(
        this IServiceCollection services,
        Type? searchType = null)
    {
        var jsonOptions = new JsonSerializerOptions();

        var serializerAssembly = searchType?.Assembly ?? typeof(DocumentSerializers).Assembly;
        var serializerType = typeof(SerializerBase<>);
        var jsonSerializerType = typeof(JsonConverter<>);

        var serializers = serializerAssembly.GetTypes()
            .Where(type => IsSerializer(type, serializerType) || IsSerializer(type, jsonSerializerType))
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
                var baseClassType = jsonSerializerType.MakeGenericType(derivedType);
                var instance = Activator.CreateInstance(classWithGenericType);

                if (instance is null)
                {
                    continue;
                }

                if (classWithGenericType.IsSubclassOf(baseClassType))
                {
                    jsonOptions.Converters.Add((JsonConverter)instance);
                    continue;
                }

                BsonSerializer.RegisterSerializer(derivedType, instance as IBsonSerializer);
            }
        }

        services.AddSingleton(Options.Create(jsonOptions));
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
