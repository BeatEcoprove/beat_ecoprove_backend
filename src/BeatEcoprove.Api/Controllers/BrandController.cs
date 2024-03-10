using BeatEcoprove.Application.Brands.Queries;
using BeatEcoprove.Contracts.Brands;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("extension/brands")]
public class BrandController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public BrandController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<ActionResult<BrandResponse>> GetAllBrands()
    {
        var getAllBrandsQuery =
            await _sender.Send(new GetAllBrandsQuery());

        return getAllBrandsQuery.Match(
            brandResponse => Ok(_mapper.Map<BrandResponse>(brandResponse)),
            Problem<BrandResponse>
        );
    }
}