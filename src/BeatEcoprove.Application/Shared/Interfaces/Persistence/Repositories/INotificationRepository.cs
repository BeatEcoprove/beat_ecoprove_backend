using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using MessageId = BeatEcoprove.Domain.ProfileAggregator.ValueObjects.MessageId;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface INotificationRepository : IRepository<Notification, MessageId>
{
    Task<List<Notification>> GetAllNotificationByOwnerIdAsync(ProfileId ownerId, CancellationToken cancellationToken = default);
    Task<InviteNotification?> GetNotificationByInviteId(string code, CancellationToken cancellationToken = default);
    Task<bool> ThereIsAnyInviteForUserOnGroup(GroupId groupId, ProfileId owner, CancellationToken cancellationToken = default);
    Task DeleteAsync(MessageId id, CancellationToken cancellationToken = default);
}