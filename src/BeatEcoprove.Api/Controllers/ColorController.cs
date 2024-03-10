using BeatEcoprove.Application.Colors.Queries;
using BeatEcoprove.Contracts.Colors;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("extension/colors")]
public class ColorController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public ColorController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<ActionResult<ColorResponse>> GetAllColors()
    {
        var getAllColorsResult =
            await _sender.Send(new GetColorsQuery());

        return getAllColorsResult.Match(
            colorResponse => Ok(_mapper.Map<ColorResponse>(colorResponse)),
            Problem<ColorResponse>
        );
    }
}