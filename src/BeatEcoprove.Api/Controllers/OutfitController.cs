using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Closet.Commands.RegisterClothUsage;
using BeatEcoprove.Application.Closet.Commands.RemoveClothFromOutfit;
using BeatEcoprove.Application.Closet.Queries.GetCurrentOutfit;
using BeatEcoprove.Contracts.Activities;
using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("profiles/closet")]
public class OutfitController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public OutfitController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPut("cloth/{clothId:guid}/use")]
    public async Task<ActionResult<DailyActivityResponse>> RegisterClothUsage([FromQuery] Guid profileId, [FromRoute] Guid clothId)
    {
        var authId = HttpContext.User.GetUserId();

        var registerClothUsageResult = await _sender.Send(new
        {
            AuthId = authId,
            ProfileId = profileId,
            ClothId = clothId
        }.Adapt<RegisterClothUsageCommand>());

        return registerClothUsageResult.Match(
            response => Ok(_mapper.Map<DailyActivityResponse>(response)),
            Problem<DailyActivityResponse>
        );
    }
    
    [HttpPut("cloth/{clothId:guid}/unUse")]
    public async Task<ActionResult<DailyActivityResponse>> RemoveClothFromOutfit([FromQuery] Guid profileId, [FromRoute] Guid clothId)
    {
        var authId = HttpContext.User.GetUserId();

        var registerClothUsageResult = await _sender.Send(new
        {
            AuthId = authId,
            ProfileId = profileId,
            ClothId = clothId
        }.Adapt<RemoveClothFromOutfitCommand>());

        return registerClothUsageResult.Match(
            response => Ok(_mapper.Map<DailyActivityResponse>(response)),
            Problem<DailyActivityResponse>
        );
    }
    
    [HttpGet("outfit")]
    public async Task<ActionResult<BucketResponse>> GetCurrentOutfit([FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var registerClothUsageResult = await _sender.Send(new
        {
            AuthId = authId,
            ProfileId = profileId
        }.Adapt<GetCurrentOutfitQuery>());

        return registerClothUsageResult.Match(
            response => Ok(_mapper.Map<BucketResponse>(response)),
            Problem<BucketResponse>
        );
    }
}