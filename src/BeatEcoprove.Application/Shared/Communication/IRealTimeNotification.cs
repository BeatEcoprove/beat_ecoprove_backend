using System.Text.Json;

using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication;

public interface IRealTimeNotification
{
    ProfileId Owner { get; }
    string Type { get; }
    string ConvertToJson(JsonSerializerOptions? options = null);
}