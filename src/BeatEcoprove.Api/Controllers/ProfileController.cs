using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Closet.Commands.CreateBucket;
using BeatEcoprove.Application.Closet.Commands.CreateCloth;
using BeatEcoprove.Application.Closet.Queries.GetCloset;
using BeatEcoprove.Contracts.Closet;
using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("profiles")]
public class ProfileController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public ProfileController(
        ISender sender, 
        IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("closet")]
    public async Task<ActionResult<ClosetResponse>> GetCloset([FromQuery] Guid profileId)
    {
        var userEmail = HttpContext.User.GetEmail();

        var result = 
            await _sender.Send(new
            {
                ProfileId = profileId,
                Email = userEmail,
            }.Adapt<GetClosetQuery>());

        return result.Match(
            response => Ok(_mapper.Map<ClosetResponse>(response)),
            Problem<ClosetResponse>
        );
    }
    
    [HttpPost("closet/cloth")]
    public async Task<ActionResult<ClothResponse>> AddClothToCloset([FromForm] CreateClothRequest request, [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var result = 
            await _sender.Send( new CreateClothCommand(
                authId,
                profileId,
                request.Name,
                request.GarmentSize,
                request.GarmentType,
                request.Brand,
                request.Color,
                request.ClothAvatar.OpenReadStream()));

        return result.Match(
            response => Created(
                "",
                _mapper.Map<ClothResponse>(response)
                ),
            Problem<ClothResponse>
        );
    }
    
    [HttpPost("closet/bucket")]
    public async Task<ActionResult<string>> AddBucketToCloset(CreateBucketRequest request, [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();
        
        var result = 
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                request.Name,
                ClothIds = request.ClothIds
            }.Adapt<CreateBucketCommand>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<string>(response)),
            Problem<string>
        );
    }
}