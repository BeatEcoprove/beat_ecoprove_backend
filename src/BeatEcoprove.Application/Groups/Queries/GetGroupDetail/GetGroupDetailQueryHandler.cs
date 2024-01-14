using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupDetail;

internal sealed class GetGroupDetailQueryHandler : IQueryHandler<GetGroupDetailQuery, ErrorOr<GroupDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupService _groupService;

    public GetGroupDetailQueryHandler(IProfileManager profileManager, IGroupService groupService)
    {
        _profileManager = profileManager;
        _groupService = groupService;
    }

    public async Task<ErrorOr<GroupDao>> Handle(GetGroupDetailQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var groupId = GroupId.Create(request.GroupId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        return await _groupService.GetGroupAsync(profile.Value, groupId, cancellationToken);
    }
}