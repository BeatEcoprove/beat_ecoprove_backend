using BeatEcoprove.Domain.Shared.Models;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Serializers;

public class EntityIdGuidJsonSerializer<TId> : JsonConverter<TId>
    where TId : AggregateRootId<Guid>
{
    public override TId? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException($"Expected string for {typeof(TId).Name} deserialization.");
        }

        var guidString = reader.GetString();
        if (guidString == null)
        {
            return null;
        }

        var guid = Guid.Parse(guidString);

        var stronglyTypedIdCtor = typeof(TId)
            .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(Guid) }, null);

        if (stronglyTypedIdCtor == null)
        {
            throw new JsonException($"No suitable constructor found for {typeof(TId).Name} deserialization.");
        }

        return (TId)stronglyTypedIdCtor.Invoke(new object[] { guid });
    }

    public override void Write(Utf8JsonWriter writer, TId value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value.ToString());
    }
}
