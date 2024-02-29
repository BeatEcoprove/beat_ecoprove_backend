using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Profiles.Queries.GetNotifications;
using BeatEcoprove.Contracts.Profile.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("profiles")]
public class NotificationController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public NotificationController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("notifications")]
    public async Task<ActionResult<List<dynamic>>> GetNotifications
    (
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default
    )
    {
        var authId = HttpContext.User.GetUserId();

        var getNotifications = await _sender.Send(
            new GetNotificationQuery(
                authId,
                profileId),
            cancellationToken
        );

        return getNotifications.Match(
            response => Ok(ProxyResponse(response)),
            Problem<List<dynamic>>
        );
    }

    private dynamic ProxyResponse(List<Notification> notifications)
    {
        return notifications
            .Select(notification =>
            {
                object response = notification switch
                {
                    InviteNotification inviteNotification => _mapper.Map<InviteNotificationResponse>(inviteNotification),
                    LeveUpNotification levelUpNotification => _mapper.Map<LevelUpNotificationResponse>(levelUpNotification),
                    Notification genericNotification => _mapper.Map<NotificationResponse>(genericNotification),
                    _ => throw new ArgumentException("Unsupported notification type"),
                };

                return response;
            }).ToList();
    }
}