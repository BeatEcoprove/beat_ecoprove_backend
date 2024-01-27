using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface INotificationSender
{
    Task SendNotificationAsync(Guid userId, SendNotification notification, CancellationToken cancellationToken = default);
}