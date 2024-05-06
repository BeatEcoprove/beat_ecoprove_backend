using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Infrastructure.Shared;

using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Notifications;

public class MessageConfiguration : IDocumentTypeConfiguration<Message>
{
    public void Configure(BsonClassMap<Message> map)
    {
        map.SetDiscriminator(nameof(Message));

        map.MapMember(x => x.Group)
            .SetElementName("group_id")
            .SetIsRequired(true);

        map.MapMember(x => x.Sender)
            .SetElementName("sender_id")
            .SetIsRequired(true);

        map.MapMember(x => x.Title)
            .SetElementName("title")
            .SetIsRequired(true);

        map.SetIgnoreExtraElements(true);
    }
}