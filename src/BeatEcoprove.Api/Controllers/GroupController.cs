using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Groups.Commands.AcceptBorrowCloth;
using BeatEcoprove.Application.Groups.Commands.AcceptInvite;
using BeatEcoprove.Application.Groups.Commands.CreateGroup;
using BeatEcoprove.Application.Groups.Commands.DeleteGroup;
using BeatEcoprove.Application.Groups.Commands.InviteMember;
using BeatEcoprove.Application.Groups.Commands.KickMember;
using BeatEcoprove.Application.Groups.Commands.PromoteMember;
using BeatEcoprove.Application.Groups.Commands.UpdateGroup;
using BeatEcoprove.Application.Groups.Queries.DeclineInvite;
using BeatEcoprove.Application.Groups.Queries.GetGroupDetail;
using BeatEcoprove.Application.Groups.Queries.GetGroupMessages;
using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Application.Groups.Queries.GetGroups;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.Groups;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/groups")]
public class GroupController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public GroupController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture) : base(languageCulture)
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
                request.PictureStream,
                request.Name,
                request.Description,
                request.IsPublic
            ));

        return createGroupResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }

    [HttpPost("{groupId:guid}/messages/{messageId}")]
    public async Task<ActionResult<AcceptBorrowClothResponse>> AcceptBorrowCloth(
        [FromQuery] Guid profileId,
        [FromRoute] string messageId,
        CancellationToken cancellationToken = default
    )
    {
        var authId = HttpContext.User.GetUserId();

        var messageIdResult = await _sender.Send(
            new AcceptBorrowCommand(
                authId,
                profileId,
                messageId
            ),
            cancellationToken
        );

        return messageIdResult.Match(
            result => Ok(new AcceptBorrowClothResponse(result)),
            Problem<AcceptBorrowClothResponse>
        );
    }

    [HttpGet("{groupId:guid}/messages")]
    public async Task<ActionResult<List<dynamic>>> GetGroupMessages(
        [FromRoute] Guid groupId,
        [FromQuery] Guid profileId,
        [FromQuery] int? page,
        [FromQuery] int? pageSize
    )
    {
        var authId = HttpContext.User.GetUserId();

        var getGroupMessagesResult = await _sender.Send(
            new GetGroupMessagesQuery(
                authId,
                profileId,
                groupId,
                page ?? 1,
                pageSize ?? 10
            ));

        return getGroupMessagesResult.Match(
            result => Ok(ProxyResponse(result)),
            Problem<List<dynamic>>
        );
    }

    private dynamic ProxyResponse(List<MessageResult> messages)
    {
        return messages
            .Select(message =>
            {
                object response = message switch
                {
                    BorrowMessageResult borrowMessage => _mapper.Map<BorrowMessageResponse>(borrowMessage),
                    MessageResult genericMessage => _mapper.Map<TextMessageResponse>(genericMessage),
                    _ => throw new ArgumentException("Unsupported notification type"),
                };

                return response;
            }).ToList();
    }

    [HttpGet]
    public async Task<ActionResult<GetGroupsResponse>> GetGroups(
        [FromQuery] Guid profileId,
        [FromQuery] string? search,
        [FromQuery] int? page,
        [FromQuery] int? pageSize
    )
    {
        var authId = HttpContext.User.GetUserId();

        var getGroupResult = await _sender.Send(
            new GetGroupsQuery(
                authId,
                profileId,
                search,
                page ?? 1,
                pageSize ?? 10
            ));

        return getGroupResult.Match(
            result => Ok(_mapper.Map<GetGroupsResponse>(result)),
            Problem<GetGroupsResponse>
        );
    }

    [HttpGet("{groupId:guid}")]
    public async Task<ActionResult<GetGroupDetailResponse>> GetDetailGroup(
        Guid groupId,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var getDetailGroup = await _sender.Send(
            new GetGroupDetailQuery(
                authId,
                profileId,
                groupId
            )
        );

        return getDetailGroup.Match(
            result => Ok(_mapper.Map<GetGroupDetailResponse>(result)),
            Problem<GetGroupDetailResponse>
        );
    }

    [HttpPatch("{groupId:guid}/promote/{memberId:guid}/{role}")]
    public async Task<ActionResult<GroupResponse>> PromoteUser(
        [FromRoute] Guid groupId,
        [FromRoute] Guid memberId,
        [FromRoute] string role,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var promoteUserResult = await _sender.Send(
            new PromoteMemberCommand(
                authId,
                profileId,
                groupId,
                memberId,
                role
            )
        );

        return promoteUserResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }

    [HttpPatch("{groupId:guid}/kick/{memberId:guid}")]
    public async Task<ActionResult<GroupResponse>> KickUser(
        [FromRoute] Guid groupId,
        [FromRoute] Guid memberId,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var promoteUserResult = await _sender.Send(
            new KickMemberCommand(
                authId,
                profileId,
                groupId,
                memberId
        ));

        return promoteUserResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }

    [HttpDelete("{groupId:guid}")]
    public async Task<ActionResult<GroupResponse>> DeleteGroup(
        [FromRoute] Guid groupId,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var deleteGroupResult = await _sender.Send(
            new DeleteGroupCommand(
                authId,
                profileId,
                groupId
            )
        );

        return deleteGroupResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }

    [HttpPut("{groupId:guid}/update/{memberId:guid}")]
    public async Task<ActionResult<GroupResponse>> UpdateGroup(
        [FromRoute] Guid groupId,
        [FromRoute] Guid memberId,
        [FromQuery] Guid profileId,
        [FromForm] UpdateGroupRequest request)
    {
        var authId = HttpContext.User.GetUserId();

        var updateGroupResult = await _sender.Send(
            new UpdateGroupCommand(
                authId,
                profileId,
                groupId,
                memberId,
                request.Name,
                request.Description,
                request.IsPublic,
                request.PictureStream
            )
        );

        return updateGroupResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }

    [HttpPatch("{groupId:guid}/invite/{inviteeId:guid}")]
    public async Task<ActionResult<GroupResponse>> InviteUser(
        [FromRoute] Guid groupId,
        [FromRoute] Guid inviteeId,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var inviteUserResult = await _sender.Send(
            new InviteMemberCommand(
                authId,
                profileId,
                groupId,
                inviteeId
            )
        );

        return inviteUserResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }

    [HttpPatch("{groupId:guid}/invite/{code:int}/accept")]
    public async Task<ActionResult<GroupResponse>> AcceptInvite(
        [FromRoute] Guid groupId,
        [FromRoute] int code,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var acceptInviteResult = await _sender.Send(
            new AcceptInviteCommand(
                authId,
                profileId,
                groupId,
                code
            )
        );

        return acceptInviteResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }


    [HttpPatch("{groupId:guid}/invite/{code:int}/decline")]
    public async Task<ActionResult<GroupResponse>> DeclineInvite(
        [FromRoute] Guid groupId,
        [FromRoute] int code,
        [FromQuery] Guid profileId)
    {
        var authId = HttpContext.User.GetUserId();

        var acceptInviteResult = await _sender.Send(
            new DeclineInviteCommand(
                authId,
                profileId,
                groupId,
                code
            )
        );

        return acceptInviteResult.Match(
            result => Ok(_mapper.Map<GroupResponse>(result)),
            Problem<GroupResponse>
        );
    }
}