using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Text.Json;

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
    public DateTimeOffset CreatedAt {  get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset DeletedAt { get; private set; }
    public abstract string Type { get; }

    public string ConvertToJson()
    {
        var options = new JsonSerializerOptions();

        return JsonSerializer.Serialize(this, options);
    }
}
