using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using MongoDB.Driver;

using MessageId = BeatEcoprove.Domain.ProfileAggregator.ValueObjects.MessageId;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class NotificationRepository : DocumentRepository<Notification, MessageId>, INotificationRepository
{
    public NotificationRepository(IMongoDatabase database)
        : base(database)
    {
    }

    public async Task<List<Notification>> GetAllNotificationByOwnerIdAsync(ProfileId ownerId, CancellationToken cancellationToken = default)
    {
        var filter = Builders<Notification>.Filter.And(
            Builders<Notification>.Filter.Eq("Owner", ownerId),
            Builders<Notification>.Filter.Eq("DeletedAt", 0));

        return await Collection
            .Find(filter)
            .ToListAsync(cancellationToken);
    }

    public async Task<InviteNotification?> GetNotificationByInviteId(string code, CancellationToken cancellationToken = default)
    {
        var filter = Builders<Notification>
            .Filter
            .Eq("code", code);

        var result = await Collection
            .Find(filter)
            .FirstOrDefaultAsync(cancellationToken);

        return result as InviteNotification;
    }

    public async Task<bool> ThereIsAnyInviteForUserOnGroup(Domain.GroupAggregator.ValueObjects.GroupId groupId, ProfileId owner, CancellationToken cancellationToken = default)
    {
        var filter = Builders<Notification>.Filter
            .And(
                Builders<Notification>.Filter.Eq("group_id", groupId),
                Builders<Notification>.Filter.Eq("owner", owner)
            );

        return await Collection
            .Find(filter)
            .AnyAsync(cancellationToken);
    }
}