using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Text.Json;

namespace BeatEcoprove.Application.Shared.Communication;

public interface IRealTimeNotification
{
    ProfileId Owner { get; }
    string Type { get; }
    string ConvertToJson(JsonSerializerOptions? options = null);
}