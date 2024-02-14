using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class NotificationRepository : DocumentRepository<Notification, MessageId>, INotificationRepository
{
    public NotificationRepository(IMongoDatabase database) 
        : base(database)
    {
    }

    public async Task<List<Notification>> GetAllNotificationByOnwerIdAsync(ProfileId ownerId, CancellationToken cancellationToken = default)
    {
        var filter = Builders<Notification>
            .Filter
            .Eq("Owner", ownerId);

        return await Collection
            .Find(filter)
            .ToListAsync(cancellationToken);
    }
}
