using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Cloths.Commands.CloseMaintenanceActivity;
using BeatEcoprove.Application.Cloths.Commands.PerformAction;
using BeatEcoprove.Application.Cloths.Queries.GetAvailableServices;
using BeatEcoprove.Application.Cloths.Queries.GetClothMaintenanceStatus;
using BeatEcoprove.Contracts.Closet.Cloth;
using BeatEcoprove.Contracts.Services;

using Mapster;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("/profiles/closet/cloth/{clothId:guid}/services")]
public class ClothController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _sender;

    public ClothController(IMapper mapper, ISender sender)
    {
        _mapper = mapper;
        _sender = sender;
    }

    [HttpGet]
    public async Task<ActionResult<List<MaintenanceServiceResponse>>> GetAvailableServices([FromRoute] Guid clothId, [FromQuery] Guid profileId, CancellationToken cancellationToken = default)
    {
        var userId = HttpContext.User.GetUserId();

        var result = await _sender.Send(new
        {
            AuthId = userId,
            ProfileId = profileId,
            ClothId = clothId
        }.Adapt<GetAvailableServicesQuery>());

        return result.Match(
            response => Ok(_mapper.Map<List<MaintenanceServiceResponse>>(response)),
            Problem<List<MaintenanceServiceResponse>>
        );
    }

    [HttpPost("{serviceId:guid}/perform/{actionId:guid}")]
    public async Task<ActionResult<ClothResponse>> PerformService(
        [FromRoute] Guid clothId,
        [FromRoute] Guid serviceId,
        [FromRoute] Guid actionId,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default)
    {
        var userId = HttpContext.User.GetUserId();

        var result = await _sender.Send(new
        {
            AuthId = userId,
            ProfileId = profileId,
            ClothId = clothId,
            ServiceId = serviceId,
            ActionId = actionId
        }.Adapt<PerformActionCommand>(), cancellationToken);

        return result.Match(
            response => Ok(_mapper.Map<ClothResponse>(response)),
            Problem<ClothResponse>
        );
    }

    [HttpPost("{maintenanceActivityId:guid}/finish")]
    public async Task<ActionResult<ClothResponse>> CloseAction(
        [FromRoute] Guid clothId,
        [FromRoute] Guid maintenanceActivityId,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default)
    {
        var userId = HttpContext.User.GetUserId();

        var result = await _sender.Send(new
        CloseMaintenanceActivityCommand(
            userId,
            profileId,
            clothId,
            maintenanceActivityId
        ), cancellationToken);

        return result.Match(
            response => Ok(_mapper.Map<ClothResponse>(response)),
            Problem<ClothResponse>
        );
    }

    // Status response
    [HttpGet("current")]
    public async Task<ActionResult<ClothMaintenanceStatusResponse>> GetClothMaintenanceStatus(
        [FromRoute] Guid profileId,
        [FromRoute] Guid clothId)
    {
        var authId = HttpContext.User.GetUserId();

        var currentStatus = await _sender.Send(new
            GetClothMaintenanceStatusQuery(
                authId,
                profileId,
                clothId
                )
        );

        return currentStatus.Match(
            response => Ok(_mapper.Map<ClothMaintenanceStatusResponse>(response)),
            Problem<ClothMaintenanceStatusResponse>
        );
    }
}