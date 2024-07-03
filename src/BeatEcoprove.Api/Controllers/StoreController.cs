using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.AddStore;
using BeatEcoprove.Application.Stores.Queries.GetOwningStores;
using BeatEcoprove.Application.Stores.Queries.GetStoreById;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
// [AuthorizationRole("organization")]
[Route("v{version:apiVersion}/stores")]
public class StoreController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;
    
    public StoreController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture localizer
    ) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("own")]
    public async Task<ActionResult<List<StoreResponse>>> GetOwningStores(
        [FromQuery] Guid profileId,
        [FromQuery] string? search = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        CancellationToken cancellationToken = default
    ) {
        var authId = HttpContext.User.GetUserId();
                
        var getOwningStores = await _sender.Send(new
            GetOwningStoresQuery(
                authId,
                profileId,
                search,
                page,
                pageSize
            ), cancellationToken
        );
        
        return getOwningStores.Match(
            result => Ok(_mapper.Map<List<StoreResponse>>(result)),
            Problem<List<StoreResponse>>
        );
    }

    [HttpGet("{storeId:guid}")]
    public async Task<ActionResult<StoreResponse>> GetStoreById(
        [FromRoute] Guid storeId,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
        
        var getStoreResult = await _sender.Send(new
            GetStoreByIdQuery(
                authId,
                profileId,
                storeId
            ), cancellationToken
        );
        
        return getStoreResult.Match(
            result => Ok(_mapper.Map<StoreResponse>(result)),
            Problem<StoreResponse>
        );
    }
    
    [HttpPost]
    public async Task<ActionResult<StoreResponse>> CreateStore(
        [FromForm] CreateStoreRequest request,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default
    ) {
        var authId = HttpContext.User.GetUserId();

        var createStoreResult = await _sender.Send(new
            AddStoreCommand(
                authId,
                profileId,
                request.Name,
                request.Country,
                request.Locality,
                request.Street,
                request.PostalCode,
                request.Port,
                request.Lat,
                request.Lon,
                request.PictureStream
            ), cancellationToken
        );
        
        return createStoreResult.Match(
            result => Ok(_mapper.Map<StoreResponse>(result)),
            Problem<StoreResponse>
        );
    }
}