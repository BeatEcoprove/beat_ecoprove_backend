using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetNotifications;

public record GetNotificationQuery
(
    Guid AuthId,
    Guid ProfileId
) : IQuery<ErrorOr<List<Notification>>>, IAuthorization;