using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Profiles.Queries;
using BeatEcoprove.Contracts.Profile;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("profile")]
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
    public async Task<ActionResult<List<ClothResponse>>> GetCloset()
    {
        var userEmail = HttpContext.User.GetEmail();

        var result = 
            await _sender.Send(new
            {
                UserEmail = userEmail
            }.Adapt<GetClosetQuery>());

        return result.Match(
            response => Ok(_mapper.Map<List<ClothResponse>>(response)),
            Problem<List<ClothResponse>>
        );
    }
}