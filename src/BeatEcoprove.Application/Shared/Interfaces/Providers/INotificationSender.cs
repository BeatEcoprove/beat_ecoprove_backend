using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface INotificationSender
{
    Task SendNotificationAsync(ProfileId userId, SendNotification notification, CancellationToken cancellationToken = default);
}