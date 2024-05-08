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
                    src.Title,
                    src.Type
                ));

        config.NewConfig<InviteNotification, InviteNotificationResponse>()
            .MapWith(src => new InviteNotificationResponse
                (
                    src.Title,
                    src.GroupId,
                    src.GroupName,
                    src.InvitorId,
                    src.Code,
                    src.Type
                ));

        config.NewConfig<LeveUpNotification, LevelUpNotificationResponse>()
            .MapWith(src => new LevelUpNotificationResponse
                (
                    src.Title,
                    src.StagedLevel,
                    src.StagedXp,
                    src.Type
                ));
    }
}