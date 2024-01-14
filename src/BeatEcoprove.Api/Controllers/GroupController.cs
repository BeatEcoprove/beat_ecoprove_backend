using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Groups.Commands.CreateGroup;
using BeatEcoprove.Application.Groups.Queries.GetGroups;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Groups;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("/groups")]
public class GroupController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public GroupController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<GroupResponse>> CreateGroup([FromQuery] Guid profileId, [FromForm] CreateGroupRequest request)
    {
        var authId = HttpContext.User.GetUserId();

        var createGroupResult = await _sender.Send(
            new CreateGroupCommand(
                authId,
                profileId,
                request.AvatarPicture.OpenReadStream(),
                request.Name,
                request.Description,
                request.IsPublic
            ));
        
        return createGroupResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }
    
    [HttpGet]
    public async Task<ActionResult<GetGroupsResponse>> GetGroups(
        [FromQuery] Guid profileId
    )
    {
        var authId = HttpContext.User.GetUserId();

        var getGroupResult = await _sender.Send(
            new GetGroupsQuery(
                authId,
                profileId
            ));
        
        return getGroupResult.Match(
            result => Ok(_mapper.Map<GetGroupsResponse>(result)),
            Problem<GetGroupsResponse>
        );
    }
}