using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupMessages;

internal sealed class GetGroupMessagesQueryHandler : IQueryHandler<GetGroupMessagesQuery, ErrorOr<List<MessageResult>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;

    public GetGroupMessagesQueryHandler(
        IProfileManager profileManager, 
        IGroupRepository groupRepository)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
    }

    public async Task<ErrorOr<List<MessageResult>>> Handle(GetGroupMessagesQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var groupId = GroupId.Create(request.GroupId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        if (!await _groupRepository.IsMemberAsync(groupId, profile.Value.Id, cancellationToken))
        {
            return Errors.Groups.MemberNotFound;
        }
        
        var messages = await _groupRepository.GetGroupMessagesAsync(
            groupId, 
            request.Page, 
            request.PageSize, 
            cancellationToken);

        return messages;
    }
}