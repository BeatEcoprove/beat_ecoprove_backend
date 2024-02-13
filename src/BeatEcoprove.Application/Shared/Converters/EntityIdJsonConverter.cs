using BeatEcoprove.Domain.Shared.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeatEcoprove.Application.Shared.Converters;

public class EntityIdJsonConverter : JsonConverter<AggregateRootId<Guid>>
{
    public override AggregateRootId<Guid>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, AggregateRootId<Guid> value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value.ToString());
    }
}
    
