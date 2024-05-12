using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.FeedBacks.Commands.SubmitFeedBack;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.FeedBacks;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/extensions/feedback")]
public class FeedBackController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public FeedBackController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture) : base(languageCulture)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<FeedBackResponse>> SubmitFeedBack(
        [FromBody] FeedBackRequest request,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken)
    {
        var authId = HttpContext.User.GetUserId();

        var submitFeedBack = await _sender.Send(
            new SubmitFeedBackCommand(
                authId,
                profileId,
                request.Title,
                request.Description),
            cancellationToken);

        return submitFeedBack.Match(
            result => Ok(_mapper.Map<FeedBackResponse>(result)),
            Problem<FeedBackResponse>
        );
    }
}