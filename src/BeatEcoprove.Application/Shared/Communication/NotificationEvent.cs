using System.Text.Json;

using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication;

public abstract class NotificationEvent<TContent> : IRealTimeNotification
{
    public NotificationEvent(ProfileId owner, TContent content)
    {
        Content = content;
        Owner = owner;
    }

    public TContent Content { get; init; }
    public ProfileId Owner { get; init; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset DeletedAt { get; private set; }
    public abstract string Type { get; }

    public string ConvertToJson(JsonSerializerOptions? options = null)
    {
        return JsonSerializer.Serialize(this, options);
    }
}