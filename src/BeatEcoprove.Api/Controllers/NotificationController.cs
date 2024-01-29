using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Profiles.Queries.GetNotifications;
using BeatEcoprove.Contracts.Profile;
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
    public async Task<ActionResult<List<NotificationResponse>>> GetNotifications
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
            response => Ok(_mapper.Map<List<NotificationResponse>>(response)),
            Problem<List<NotificationResponse>>
        );
    }
    
}