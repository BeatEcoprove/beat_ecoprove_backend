using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Infrastructure.Shared;

using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Notifications;

public class LevelUpNotificationConfiguration : IDocumentTypeConfiguration<LeveUpNotification>
{
    public void Configure(BsonClassMap<LeveUpNotification> map)
    {
        map.SetDiscriminator(nameof(LeveUpNotification));

        map.MapMember(x => x.StagedLevel)
            .SetElementName("staged_level")
            .SetIsRequired(true);

        map.MapMember(x => x.StagedXp)
            .SetElementName("staged_xp")
            .SetIsRequired(true);

        map.SetIgnoreExtraElements(true);
    }
}