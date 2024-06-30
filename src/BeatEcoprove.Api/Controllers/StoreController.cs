using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.AddStore;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BeatEcoprove.Api.Controllers;

// [ApiVersion(1)]
[Authorize]
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

    [HttpPost()]
    public async Task<ActionResult<StoreResponse>> CreateStore(
        CreateStoreRequest request,
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
                request.Picture.OpenReadStream()
            ), cancellationToken
        );
        
        return createStoreResult.Match(
            result => Ok(_mapper.Map<StoreResponse>(result)),
            Problem<StoreResponse>
        );
    }
}