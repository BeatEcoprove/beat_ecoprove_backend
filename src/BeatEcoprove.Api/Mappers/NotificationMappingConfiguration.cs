using BeatEcoprove.Contracts.Profile.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class NotificationMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Notification, NotificationResponse>()
            .MapWith(src => new NotificationResponse
                (
                    src.Title
                ));


        config.NewConfig<InviteNotification, InviteNotificationResponse>()
            .MapWith(src => new InviteNotificationResponse
                (
                    src.Title,
                    src.GroupId,
                    src.InvitorId,
                    src.Code
                ));
    }
}
