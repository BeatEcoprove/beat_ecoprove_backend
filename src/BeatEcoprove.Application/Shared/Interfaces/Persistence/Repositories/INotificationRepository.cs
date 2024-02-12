using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface INotificationRepository : IRepository<Notification, NotificationId>
{
    Task<List<Notification>> GetAllNotificationByOnwerIdAsync(ProfileId ownerId, CancellationToken cancellationToken = default);
}
