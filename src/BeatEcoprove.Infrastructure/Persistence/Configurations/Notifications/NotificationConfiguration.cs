using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Infrastructure.Shared;
using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Notifications;

public class NotificationConfiguration : IDocumentTypeConfiguration<Notification>
{
    public void Configure(BsonClassMap<Notification> map)
    {
        map.SetDiscriminator(nameof(Notification));

        map.MapMember(n => n.Title)
            .SetElementName("title");

        map.MapMember(n => n.Owner)
            .SetElementName("owner");
    }
}
