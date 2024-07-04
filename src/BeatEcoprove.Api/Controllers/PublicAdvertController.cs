using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Queries.GetAdevertById;
using BeatEcoprove.Application.Stores.Queries.GetHomeAdds;
using BeatEcoprove.Contracts.Advertisements;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/public/adverts")]
public class PublicAdvertController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public PublicAdvertController(
        ILanguageCulture localizer, 
        ISender sender, 
        IMapper mapper) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("{advertId:guid}")]
    public async Task<ActionResult<AdvertisementResponse>> GetById(
        [FromQuery] Guid profileId,
        [FromRoute] Guid advertId,
        CancellationToken cancellationToken = default)
    {
         var authId = HttpContext.User.GetUserId();
                        
        var getByIdAdvert = await _sender.Send(new
            GetAdvertByIdQuery(
                authId,
                profileId,
                advertId,
                false
            ), cancellationToken
        );
        
        return getByIdAdvert.Match(
            result => Ok(_mapper.Map<AdvertisementResponse>(result)),
            Problem<AdvertisementResponse>
        );
    }
    
    [HttpGet]
    public async Task<ActionResult<List<AdvertisementResponse>>> GetHomeAdds(
        [FromQuery] Guid profileId,
        [FromQuery] string? search,
        [FromQuery] int? page, 
        [FromQuery] int? pageSize,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                
        var getAllAdverts = await _sender.Send(new
            GetHomeAddsQuery(
                authId,
                profileId,
                search,
                page ?? 1,
                pageSize ?? 10
            ), cancellationToken
        );
        
        return getAllAdverts.Match(
            result => Ok(_mapper.Map<List<AdvertisementResponse>>(result)),
            Problem<List<AdvertisementResponse>>
        );
    }
}