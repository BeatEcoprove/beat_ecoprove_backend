using BeatEcoprove.Application.Shared.Communication;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface INotificationSender
{
    Task SendNotificationAsync(
        INotifer notification, 
        CancellationToken cancellationToken = default);
}