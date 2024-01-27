using ErrorOr;
using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers;

public abstract class ChatGroupWebSocketHandler : WebSocketHandler
{
    private readonly IProfileRepository _profileRepository;
    private readonly IGroupRepository _groupRepository;
    
    protected ChatGroupWebSocketHandler(
        ConnectionManager connectionManager, 
        IProfileRepository profileRepository, 
        IGroupRepository groupRepository) : base(connectionManager)
    {
        _profileRepository = profileRepository;
        _groupRepository = groupRepository;
    }
    
    protected async Task SendEveryoneAsync(Guid groupId, SendNotification notification, CancellationToken cancellationToken = default)
    {
        var users = ConnectionManager.GetGroup(groupId, cancellationToken)!;
        
        if (users is null)
        {
            return;
        }
        
        var responseBytes = Encoding.UTF8.GetBytes(notification);
        await Task.WhenAll(users.Select(user => user.Socket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
            WebSocketMessageType.Text,
            true,
            cancellationToken)));
    }
    
    protected async Task<ErrorOr<Group>> GetGroupByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var groupId = GroupId.Create(id);

        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);
        
        if (group is null)
        {
            return Errors.Groups.NotFound;
        }

        return group;
    }
    
    protected async Task<Profile?> GetProfileAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var profileId = ProfileId.Create(userId);

        return await _profileRepository.GetByIdAsync(profileId, cancellationToken);
    }
}