using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.AddWorker;
using BeatEcoprove.Application.Stores.Commands.CreateAdd;
using BeatEcoprove.Contracts.Advertisements;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
// [AuthorizationRole("organization")]
[Route("v{version:apiVersion}/stores/{storeId:guid}/add")]
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

    [HttpPost]
    public async Task<ActionResult<AdvertisementResponse>> CreateAdd(
        [FromQuery] Guid profileId,
        [FromRoute] Guid storeId,
        [FromForm] CreateAdvertisementRequest request,
        CancellationToken cancellationToken = default)
    {
         var authId = HttpContext.User.GetUserId();
                
        var createAddResult = await _sender.Send(new
            CreateAddCommand(
                authId,
                profileId,
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