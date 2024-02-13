using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Infrastructure.Shared;
using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Notifications;

public class InviteNotificationConfiguration : IDocumentTypeConfiguration<InviteNotification>
{
    public void Configure(BsonClassMap<InviteNotification> map)
    {
        map.SetDiscriminator(nameof(InviteNotification));

        map.MapMember(x => x.GroupId)
            .SetElementName("group_id")
            .SetIsRequired(true);
        
        map.MapMember(x => x.InvitorId)
            .SetElementName("invitor_id")
            .SetIsRequired(true);
        
        map.MapMember(x => x.Code)
            .SetElementName("code")
            .SetIsRequired(true);

        map.SetIgnoreExtraElements(true);
    }
}
