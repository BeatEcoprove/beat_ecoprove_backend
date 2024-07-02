using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.AddWorker;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
// [AuthorizationRole("organization")]
[Route("v{version:apiVersion}/stores/{storeId:guid}/workers")]
public class WorkerController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public WorkerController(
        ILanguageCulture localizer, 
        ISender sender, 
        IMapper mapper) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<WorkerResponse>> RegisterWorker(
        [FromQuery] Guid profileId,
        [FromRoute] Guid storeId,
        CreateWorkerRequest request,
        CancellationToken cancellationToken = default
    ) {
        var authId = HttpContext.User.GetUserId();
        
        var registerOrderResult = await _sender.Send(new
            AddWorkerCommand(
                authId,
                profileId,
                storeId,
                request.Name,
                request.Email,
                request.Permission
            ), cancellationToken
        );
        
        return registerOrderResult.Match(
            result => Ok(_mapper.Map<WorkerResponse>(result)),
            Problem<WorkerResponse>
        );
    }
}