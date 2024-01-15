using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroups;

internal sealed class GetGroupsQueryHandler : IQueryHandler<GetGroupsQuery, ErrorOr<GetGroupList>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;

    public GetGroupsQueryHandler(
        IProfileManager profileManager, 
        IGroupRepository groupRepository)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
    }
    
    public async Task<ErrorOr<GetGroupList>> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var publicGroups = await _groupRepository.GetPublicGroupsAsync(cancellationToken);
        var privateGroups = await _groupRepository.GetPrivateGroupsAsync(profile.Value.Id, cancellationToken);
        
        return new GetGroupList(
            publicGroups,
            privateGroups);
    }
}