﻿using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Closet.Commands.AddClothToBucket;
using BeatEcoprove.Application.Closet.Commands.CreateBucket;
using BeatEcoprove.Application.Closet.Commands.CreateCloth;
using BeatEcoprove.Application.Closet.Commands.RemoveBucketFromCloset;
using BeatEcoprove.Application.Closet.Commands.RemoveClothFromBucket;
using BeatEcoprove.Application.Closet.Commands.RemoveClothFromCloset;
using BeatEcoprove.Application.Closet.Queries.GetBucket;
using BeatEcoprove.Application.Closet.Queries.GetBucketsCloth;
using BeatEcoprove.Application.Closet.Queries.GetCloset;
using BeatEcoprove.Application.Closet.Queries.GetCloth;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.Closet;
using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;

using Mapster;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/profiles/closet")]
public class ClosetController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public ClosetController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture) : base(languageCulture)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet()]
    public async Task<ActionResult<ClosetResponse>> GetCloset(
        [FromQuery] Guid profileId,
        [FromQuery] string? search,
        [FromQuery] string? size,
        [FromQuery] string? category,
        [FromQuery] string? color,
        [FromQuery] string? brand,
        [FromQuery] string? orderBy,
        [FromQuery] string? sortBy,
        [FromQuery] int? page,
        [FromQuery] int? pageSize)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                ProfileId = profileId,
                AuthId = authId,
                Search = search,
                Categories = category,
                Size = size,
                Color = color,
                Brand = brand,
                OrderBy = orderBy,
                SortBy = sortBy,
                Page = page,
                PageSize = pageSize
            }.Adapt<GetClosetQuery>());

        return result.Match(
            response => Ok(_mapper.Map<ClosetResponse>(response)),
            Problem<ClosetResponse>
        );
    }

    [HttpPost("cloth")]
    public async Task<ActionResult<ClothResponse>> AddClothToCloset([FromForm] CreateClothRequest request, [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new CreateClothCommand(
                authId,
                profileId,
                request.Name,
                request.ClothType,
                request.ClothSize,
                request.Brand,
                request.Color,
                request.PictureStream));

        return result.Match(
            response => Created(
                "",
                _mapper.Map<ClothResponse>(response)
                ),
            Problem<ClothResponse>
        );
    }

    [HttpGet("cloth/{clothId:guid}/buckets")]
    public async Task<ActionResult<List<BucketResponse>>> GetClothBuckets([FromQuery] Guid profileId, Guid clothId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                ClothId = clothId
            }.Adapt<GetBucketsClothQuery>());

        return result.Match(
           ok => _mapper.Map<List<BucketResponse>>(ok),
            Problem<List<BucketResponse>>
        );
    }

    [HttpGet("cloth/{clothId:guid}")]
    public async Task<ActionResult<ClothResponse>> GetCloth([FromQuery] Guid profileId, Guid clothId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                ClothId = clothId
            }.Adapt<GetClothQuery>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<ClothResponse>(response)
            ),
            Problem<ClothResponse>
        );
    }

    [HttpDelete("cloth/{clothId:guid}")]
    public async Task<ActionResult<ClothResponse>> RemoveClothFromCloset([FromQuery] Guid profileId, Guid clothId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                ClothId = clothId
            }.Adapt<RemoveClothFromClosetCommand>());

        return result.Match(
            response => Created(
                "",
                response.Adapt<ClothResponse>()
            ),
            Problem<ClothResponse>
        );
    }

    [HttpPost("bucket")]
    public async Task<ActionResult<BucketResponse>> AddBucketToCloset(CreateBucketRequest request, [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                request.Name,
                request.ClothIds
            }.Adapt<CreateBucketCommand>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<BucketResponse>(response)),
            Problem<BucketResponse>
        );
    }

    [HttpGet("bucket/{bucketId:guid}")]
    public async Task<ActionResult<BucketResponse>> GetBucket([FromQuery] Guid profileId, Guid bucketId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                BucketId = bucketId
            }.Adapt<GetBucketQuery>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<BucketResponse>(response)
            ),
            Problem<BucketResponse>
        );
    }

    [HttpDelete("bucket/{bucketId:guid}")]
    public async Task<ActionResult<BucketResponse>> RemoveBucketFromCloset([FromQuery] Guid profileId, Guid bucketId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                BucketId = bucketId
            }.Adapt<RemoveBucketFromClosetCommand>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<BucketResponse>(response)
            ),
            Problem<BucketResponse>
        );
    }

    [HttpPut("bucket/{bucketId:guid}/add")]
    public async Task<ActionResult<BucketResponse>> AddClothsToBucket(AddClothToBucketRequest request, [FromQuery] Guid profileId, Guid bucketId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                BucketId = bucketId,
                request.ClothToAdd
            }.Adapt<AddClothToBucketCommand>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<BucketResponse>(response)),
            Problem<BucketResponse>
        );
    }

    [HttpPut("bucket/{bucketId:guid}/remove")]
    public async Task<ActionResult<BucketResponse>> RemoveClothFromBucket(RemoveClothFromBucketRequest request, [FromQuery] Guid profileId, Guid bucketId)
    {
        var authId = HttpContext.User.GetUserId();

        var result =
            await _sender.Send(new
            {
                AuthId = authId,
                ProfileId = profileId,
                BucketId = bucketId,
                request.ClothToRemove
            }.Adapt<RemoveClothFromBucketCommand>());

        return result.Match(
            response => Created(
                "",
                _mapper.Map<BucketResponse>(response)),
            Problem<BucketResponse>
        );
    }
}