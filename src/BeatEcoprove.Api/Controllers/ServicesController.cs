using BeatEcoprove.Application.Services.Queries.GetAllServices;
using BeatEcoprove.Contracts.Services;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("services")]
public class ServicesController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public ServicesController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<MaintenanceServiceResponse>>> GetAllServices()
    {
        var services = await _sender.Send(new GetAllServicesQuery());
        
        return services.Match(
            result => _mapper.Map<List<MaintenanceServiceResponse>>(result),
            Problem<List<MaintenanceServiceResponse>>
        );
    }
}