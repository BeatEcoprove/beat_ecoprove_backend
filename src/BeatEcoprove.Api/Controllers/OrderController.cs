using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.RegisterOrder;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
// [AuthorizationRole("organization")]
[Route("v{version:apiVersion}/stores/{storeId:guid}/orders")]
public class OrderController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public OrderController(
        ILanguageCulture localizer, 
        ISender sender, 
        IMapper mapper) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPost()]
    public async Task<ActionResult<OrderResponse>> InsertOrder(
        [FromQuery] Guid profileId,
        [FromRoute] Guid storeId,
        [FromQuery] Guid clothId,
        [FromQuery] Guid ownerId,
        CancellationToken cancellationToken = default
        )
    {
        var authId = HttpContext.User.GetUserId();
        
        var registerOrderResult = await _sender.Send(new
            RegisterOrderCommand(
                authId, 
                profileId, 
                storeId, 
                ownerId, 
                clothId
            ), cancellationToken
        );
        
        return registerOrderResult.Match(
            result => Ok(_mapper.Map<OrderResponse>(result)),
            Problem<OrderResponse>
        );
    }
}