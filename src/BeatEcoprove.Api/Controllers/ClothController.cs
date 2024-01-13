using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Cloths.Queries.GetAvailableServices;
using BeatEcoprove.Contracts.Services;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("/profiles/closet/cloth/{clothId:guid}")]
public class ClothController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _sender;

    public ClothController(IMapper mapper, ISender sender)
    {
        _mapper = mapper;
        _sender = sender;
    }

    [HttpGet("services")]
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
}