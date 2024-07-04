using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Api.Mappers;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.RegisterOrder;
using BeatEcoprove.Application.Stores.Queries.GetOrderById;
using BeatEcoprove.Application.Stores.Queries.GetOrders;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[AuthorizationRole("organization", "employee")]
[Route("v{version:apiVersion}/orders")]
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

    [HttpGet("{orderId:guid}/stores/{storeId:guid}")]
    public async Task<ActionResult<OrderResponse>> GetOrderById(
        [FromQuery] Guid profileId,
        [FromRoute] Guid orderId,
        [FromRoute] Guid storeId,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
        
        var registerOrderResult = await _sender.Send(new
            GetOrderByIdQuery(
                authId,
                profileId,
                orderId,
                storeId
            ), cancellationToken
        );
        
        return registerOrderResult.Match(
            result => Ok(_mapper.Map<OrderResponse>(result)),
            Problem<OrderResponse>
        );
    }

    [HttpGet]
    public async Task<ActionResult<List<dynamic>>> GetOrders(
        [FromQuery] Guid profileId,
        [FromQuery] string storeIds,
        [FromQuery] string? search,
        [FromQuery] string? services,
        [FromQuery] string? color,
        [FromQuery] string? brand,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] bool isDone = false,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();
                
        var registerOrderResult = await _sender.Send(new
            GetOrdersQuery(
                authId, 
                profileId, 
                storeIds, 
                search, 
                services, 
                color, 
                brand, 
                isDone,
                page, 
                pageSize
            ), cancellationToken
        );
        
        return registerOrderResult.Match(
            result => Ok(result.Select(StoreMappingConfiguration.CreateOrderResponse)),
            Problem<List<dynamic>>
        );
    }
    
    [HttpPost]
    public async Task<ActionResult<OrderResponse>> InsertOrder(
        [FromQuery] Guid profileId,
        [FromQuery] Guid storeId,
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