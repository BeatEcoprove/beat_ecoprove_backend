using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.CreateAdd;
using BeatEcoprove.Application.Stores.Commands.RemoveAdvert;
using BeatEcoprove.Application.Stores.Queries.GetAdevertById;
using BeatEcoprove.Application.Stores.Queries.GetMyAdverts;
using BeatEcoprove.Contracts.Advertisements;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[AuthorizationRole("organization", "employee")]
[Route("v{version:apiVersion}/adverts")]
public class AdvertisementController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public AdvertisementController(
        ILanguageCulture localizer, 
        ISender sender, 
        IMapper mapper) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpDelete("{advertId:guid}")]
    public async Task<ActionResult<AdvertisementResponse>> DeleteAdvert(
        [FromQuery] Guid profileId,
        [FromRoute] Guid advertId,
        
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                                
        var deleteAdvert = await _sender.Send(new
            RemoveAdvertCommand(
                authId, 
                profileId, 
                advertId
            ), cancellationToken
        );
        
        return deleteAdvert.Match(
            result => Ok(_mapper.Map<AdvertisementResponse>(result)),
            Problem<AdvertisementResponse>
        );
    }

    [HttpGet]
    public async Task<ActionResult<List<AdvertisementResponse>>> GetMyAdverts(
        [FromQuery] Guid storeId,
        [FromQuery] Guid profileId,
        [FromQuery] string? search,
        [FromQuery] int? page, 
        [FromQuery] int? pageSize,
        CancellationToken cancellationToken = default) {
        var authId = HttpContext.User.GetUserId();
                        
        var getMyAdverts = await _sender.Send(new
            GetMyAdvertsQuery(
                authId,
                profileId,
                storeId,
                search,
                page ?? 1,
                pageSize ?? 10
            ), cancellationToken
        );
        
        return getMyAdverts.Match(
            result => Ok(_mapper.Map<List<AdvertisementResponse>>(result)),
            Problem<List<AdvertisementResponse>>
        );
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
                advertId
            ), cancellationToken
        );
        
        return getByIdAdvert.Match(
            result => Ok(_mapper.Map<AdvertisementResponse>(result)),
            Problem<AdvertisementResponse>
        );
    }    
    
    [HttpPost]
    public async Task<ActionResult<AdvertisementResponse>> CreateAdd(
        [FromQuery] Guid profileId,
        [FromQuery] Guid storeId,
        [FromForm] CreateAdvertisementRequest request,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                
        var createAddResult = await _sender.Send(new
            CreateAddCommand(
                authId,
                profileId,
                storeId,
                request.Title,
                request.Description,
                request.BeginAt,
                request.EndAt,
                request.PictureStream,
                request.Type,
                request.Quantity
            ), cancellationToken
        );
        
        return createAddResult.Match(
            result => Ok(_mapper.Map<AdvertisementResponse>(result)),
            Problem<AdvertisementResponse>
        );
    }
}