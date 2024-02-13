using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

namespace BeatEcoprove.Application.Shared.Communication;

public interface INotifer : IRealTimeNotification
{
    Notification GetNotification();
}
