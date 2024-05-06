using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Infrastructure.Shared;

using MongoDB.Bson.Serialization;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Notifications;

public class BorrowMessageConfiguration : IDocumentTypeConfiguration<BorrowMessage>
{
    public void Configure(BsonClassMap<BorrowMessage> map)
    {
        map.SetDiscriminator(nameof(BorrowMessage));

        map.MapMember(x => x.ClothId)
            .SetElementName("cloth_id")
            .SetIsRequired(true);

        map.SetIgnoreExtraElements(true);
    }
}