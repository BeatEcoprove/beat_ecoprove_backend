using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Application.Stores.Commands.PostRating;
using BeatEcoprove.Application.Stores.Queries.GetStoreRatings;
using BeatEcoprove.Contracts.Store;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[AuthorizationRole("organization", "employee")]
[Route("v{version:apiVersion}/stores/{storeId:guid}/ratings")]
public class RatingController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;
    
    public RatingController(
        ILanguageCulture localizer, 
        ISender sender, 
        IMapper mapper) : base(localizer)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<RatingResponse>>> GetStoreRatings(
        [FromQuery] Guid profileId,
        [FromRoute] Guid storeId,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        CancellationToken cancellationToken = default
    ) {
        var authId = HttpContext.User.GetUserId();
                        
        var getRatings = await _sender.Send(new
            GetStoreRatingsQuery(
                authId,
                profileId,
                storeId,
                page,
                pageSize
            ), cancellationToken
        );
        
        return getRatings.Match(
            result => Ok(_mapper.Map<List<RatingResponse>>(result)),
            Problem<List<RatingResponse>>
        );
    }
    
    [HttpPost]
    public async Task<ActionResult<RatingResponse>> PostRating(
        [FromQuery] Guid profileId,
        [FromRoute] Guid storeId,
        CreatePostRating request,
        CancellationToken cancellationToken = default
    ) {
        var authId = HttpContext.User.GetUserId();
                
        var postRating = await _sender.Send(new
            PostRatingCommand(
                authId,
                profileId,
                storeId,
                request.Rating
            ), cancellationToken
        );
        
        return postRating.Match(
            result => Ok(_mapper.Map<RatingResponse>(result)),
            Problem<RatingResponse>
        );
    }
}