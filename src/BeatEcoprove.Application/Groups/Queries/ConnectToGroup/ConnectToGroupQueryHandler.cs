using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Communication.Group;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.ConnectToGroup;

internal class ConnectToGroupQueryHandler : IQueryHandler<ConnectToGroupQuery, ErrorOr<bool>>
{
    private readonly ISessionManager _sessionManager;
    private readonly IGroupSessionManager _groupSessionManager;
    private readonly IProfileRepository _profileRepository;
    private readonly IGroupRepository _groupRepository;

    public ConnectToGroupQueryHandler(
        ISessionManager sessionManager, 
        IGroupSessionManager groupSessionManager, 
        IProfileRepository profileRepository, 
        IGroupRepository groupRepository)
    {
        _sessionManager = sessionManager;
        _groupSessionManager = groupSessionManager;
        _profileRepository = profileRepository;
        _groupRepository = groupRepository;
    }

    public async Task<ErrorOr<bool>> Handle(
        ConnectToGroupQuery request, 
        CancellationToken cancellationToken)
    {
        var userId = ProfileId.Create(request.UserId);
        var groupId = GroupId.Create(request.GroupId);

        if (!_sessionManager.IsUserAuthenticated(userId))
        {
            return Errors.Auth.InvalidAuth;
        }

        var profile = await _profileRepository.GetByIdAsync(userId, cancellationToken);

        if (profile is null)
        {
            return Errors.Profile.NotFound;
        }

        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);

        if (group is null)
        {
            return Errors.Groups.WSNotFound;
        }

        if (await UserCannotConnectToGroup(group, userId, cancellationToken))
        {
            return Errors.Groups.CannotAccess;
        }

        await _groupSessionManager.AddMember(
            groupId,
            new Member(
                userId,
                request.UserSocket
            ),
            cancellationToken
         );

        await _groupSessionManager.SendEveryoneAsync(
            groupId,
            new EnterOnGroupNotificationEvent(
                userId,
                new EnterOnGroupContent(
                    groupId,
                    $"O utilizador {(string)profile.UserName} entrou no grupo"
                )
            ),
            cancellationToken
        );

        return true;
    }

    private async Task<bool> UserCannotConnectToGroup(
        Group group,
        ProfileId userId, 
        CancellationToken cancellationToken)
    {
        return (!await _groupRepository.IsMemberAsync(group.Id, userId, cancellationToken)) && !group.IsPublic;
    }
}

    
