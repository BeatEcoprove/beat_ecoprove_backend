using BeatEcoprove.Application.Shared.Communication;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IRealTimeConnection
{
    Task NotifyClient<TContent>(
        NotificationEvent<TContent> @event,
        CancellationToken cancellationToken = default);
}
