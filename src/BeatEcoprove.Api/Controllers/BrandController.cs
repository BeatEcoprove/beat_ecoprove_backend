﻿using BeatEcoprove.Application.Brands.Queries;
using BeatEcoprove.Contracts.Brands;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

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

    public async Task<ActionResult<List<BrandResponse>>> GetAllBrands()
    {
        var getAllBrandsQuery = 
            await _sender.Send(new GetAllBrandsQuery());
        
        return getAllBrandsQuery.Match(
            brandResponse => Ok(_mapper.Map<List<BrandResponse>>(brandResponse)),
            Problem<List<BrandResponse>>
        );
    }
}