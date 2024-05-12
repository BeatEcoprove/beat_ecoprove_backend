using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.ClosetBuckets.Commands;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.Closet.Bucket;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;


[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/profiles/closet/bucket/{bucketId:guid}")]
public class BucketController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public BucketController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture) : base(languageCulture)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPatch]
    public async Task<ActionResult<BucketResponse>> PathBucket(
        Guid bucketId,
        [FromQuery] Guid profileId,
        [FromBody] PatchBucketRequest request)
    {
        var authId = HttpContext.User.GetUserId();

        var result = await _sender.Send(new
            PatchBucketCommand(
                authId,
                profileId,
                bucketId,
                request.Name
            ));

        return result.Match(
            response => Ok(_mapper.Map<BucketResponse>(response)),
            Problem<BucketResponse>
        );
    }
}