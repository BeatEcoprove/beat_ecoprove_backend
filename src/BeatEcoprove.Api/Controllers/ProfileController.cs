using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Profiles.Commands.AddBucketToCloset;
using BeatEcoprove.Application.Profiles.Commands.AddClothToCloset;
using BeatEcoprove.Application.Profiles.Queries.GetCloset;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Profile;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("profile/{profileId:guid}")]
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
    public async Task<ActionResult<ClosetResponse>> GetCloset(Guid profileId)
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
    public async Task<ActionResult<List<ClothResponse>>> AddClothToCloset(Guid profileId, [FromForm] AddClothToProfile request)
    {
        var userEmail = HttpContext.User.GetEmail();

        var result = 
            await _sender.Send( new AddClothToProfileCommand(
                profileId,
                userEmail,
                request.Name,
                request.Brand,
                request.Color,
                request.GarmentSize,
                request.GarmentType,
                request.ClothAvatar.OpenReadStream()));

        return result.Match(
            response => Ok(_mapper.Map<List<ClothResponse>>(response)),
            Problem<List<ClothResponse>>
        );
    }
    
    [HttpPost("closet/bucket")]
    public async Task<ActionResult<string>> AddBucketToCloset(Guid profileId, AddBucketToProfile request)
    {
        var result = 
            await _sender.Send(new
            {
                ProfileId = profileId,
                request.Name,
                ClothIds = request.ClothIds
            }.Adapt<AddBucketToClosetCommand>());

        return result.Match(
            response => Ok(_mapper.Map<string>(response)),
            Problem<string>
        );
    }
}