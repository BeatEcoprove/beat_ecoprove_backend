using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Providers.Queries.GetAllStandardProviders;
using BeatEcoprove.Application.Providers.Queries.GetProviderAdverts;
using BeatEcoprove.Application.Providers.Queries.GetProviderById;
using BeatEcoprove.Application.Providers.Queries.GetProviderStoreById;
using BeatEcoprove.Application.Providers.Queries.GetProviderStores;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.Advertisements;
using BeatEcoprove.Contracts.Providers;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/providers")]
public class ProviderController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;
    
    public ProviderController(
        ILanguageCulture localizer, 
        ISender sender, 
        IMapper mapper) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<StandardProviderResponse>>> GetAllProviders(
        [FromQuery] Guid profileId,
        [FromQuery] string? search = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        CancellationToken cancellationToken = default)
    { 
        var authId = HttpContext.User.GetUserId();
                        
        var getAllProviders = await _sender.Send(new
            GetAllStandardProvidersQuery(
                authId,
                profileId,
                search,
                page,
                pageSize
            ), cancellationToken
        );
        
        return getAllProviders.Match(
            result => Ok(_mapper.Map<List<StandardProviderResponse>>(result)),
            Problem<List<StandardProviderResponse>>
        );
    }
    
    [HttpGet("{providerId:guid}")]
    public async Task<ActionResult<ProviderResponse>> GetProviderById(
        [FromQuery] Guid profileId,
        [FromRoute] Guid providerId,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                        
        var getAllProviders = await _sender.Send(new
            GetProviderByIdQuery(
                authId,
                profileId,
                providerId
            ), cancellationToken
        );
        
        return getAllProviders.Match(
            result => Ok(_mapper.Map<ProviderResponse>(result)),
            Problem<ProviderResponse>
        );
    }

    [HttpGet("{providerId:guid}/stores")]
    public async Task<ActionResult<List<StoreResponse>>> GetStores(
        [FromQuery] Guid profileId,
        [FromRoute] Guid providerId,
        [FromQuery] string? search = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                        
        var getAllProviders = await _sender.Send(new
            GetProviderStoresQuery(
                authId, 
                profileId, 
                providerId, 
                search, 
                page, 
                pageSize
            ), cancellationToken
        );
        
        return getAllProviders.Match(
            result => Ok(_mapper.Map<List<StoreResponse>>(result)),
            Problem<List<StoreResponse>>
        );
    }

    [HttpGet("{providerId:guid}/stores/{storeId:guid}")]
    public async Task<ActionResult<StoreResponse>> GetStoreById(
        [FromQuery] Guid profileId,
        [FromRoute] Guid providerId,
        [FromRoute] Guid storeId,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                        
        var getStoreById = await _sender.Send(new
            GetProviderStoreByIdQuery(
                authId,
                profileId,
                providerId,
                storeId
            ), cancellationToken
        );
        
        return getStoreById.Match(
            result => Ok(_mapper.Map<StoreResponse>(result)),
            Problem<StoreResponse>
        );
    }

    [HttpGet("{providerId:guid}/adverts")]
    public async Task<ActionResult<List<AdvertisementResponse>>> GetProviderAdverts(
        [FromQuery] Guid profileId,
        [FromRoute] Guid providerId, 
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                        
        var getAdverts = await _sender.Send(new
            GetProviderAdvertsQuery(
                authId,
                profileId, 
                providerId
            ), cancellationToken
        );
        
        return getAdverts.Match(
            result => Ok(_mapper.Map<List<AdvertisementResponse>>(result)),
            Problem<List<AdvertisementResponse>>
        );
    }
}