using System.Net.WebSockets;
using System.Text;
using System.Text.Json.Serialization;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Notifications;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers;

public class ConnectToGroupMessage
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }
}

public class SendTextMessage
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }
    
    [JsonPropertyName("message")]
    public string Message { get; init; } = string.Empty;
}

public class ChatGroupHandler
{
    private readonly ConnectionManager _connectionManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ChatGroupHandler(
        ConnectionManager connectionManager, 
        IGroupRepository groupRepository, 
        IUnitOfWork unitOfWork, 
        IProfileRepository profileRepository)
    {
        _connectionManager = connectionManager;
        _groupRepository = groupRepository;
        _unitOfWork = unitOfWork;
        _profileRepository = profileRepository;
    }
    
    private async Task<ErrorOr<Group>> GetGroupByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var groupId = GroupId.Create(id);

        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);
        
        if (group is null)
        {
            return Errors.Groups.NotFound;
        }

        return group;
    }
    
    public async Task<Profile?> GetProfileAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var profileId = ProfileId.Create(userId);

        return await _profileRepository.GetByIdAsync(profileId, cancellationToken);
    }
    
    public async Task SendEveryoneAsync(Guid groupId, SendNotification notification, CancellationToken cancellationToken = default)
    {
        var users = _connectionManager.GetGroup(groupId, cancellationToken)!;
        
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
    
    public async Task HandleConnectToGroup(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        if (!_connectionManager.AuthUsers.ContainsKey(message.UserId))
        {
            throw new Exception("Not Authenticated User");
        }
        
        var content = message.GetContent<ConnectToGroupMessage>();
        
        if (content is null)
        {
            return;
        }
        
        var profile = await GetProfileAsync(message.UserId, cancellationToken);
        
        if (profile is null)
        {
            return;
        }
        
        var group = await GetGroupByIdAsync(content.GroupId, cancellationToken);
        
        if (group.IsError)
        {
            return;
        }

        if (_connectionManager.GetGroup(content.GroupId, cancellationToken) == null)
        {
            _connectionManager.RegisterGroup(content.GroupId);
        }
        
        var shouldAddToGroup = await _connectionManager.AddToGroup(content.GroupId, message.UserId, message.Socket);
        
        if (!shouldAddToGroup)
        {
            return;
        }
        
        await SendEveryoneAsync(
            content.GroupId,
            new ServerChatTextMessage
                (
                    content.GroupId,
                    profile.Id,
                    $"O utilizador {(string)profile.UserName} entrou no grupo"
                ),
            cancellationToken
        );
    }

    public async Task HandleSendTextMessage(WebSocketMessage message, CancellationToken cancellationToken)
    {
        if (!_connectionManager.AuthUsers.ContainsKey(message.UserId))
        {
            throw new Exception("Not Authenticated User");
        }
        
        var content = message.GetContent<SendTextMessage>();
        
        if (content is null)
        {
            return;
        }
        
        var profile = await GetProfileAsync(message.UserId, cancellationToken);
        
        if (profile is null)
        {
            return;
        }
        
        var group = await GetGroupByIdAsync(content.GroupId, cancellationToken);
        
        if (group.IsError)
        {
            return;
        }
        
        var shouldAddMessage = group.Value.AddTextMessage(profile.Id, content.Message);
        
        if (shouldAddMessage.IsError)
        {
            return;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        await SendEveryoneAsync(
            content.GroupId,
            new ChatTextMessage
                (
                    content.GroupId,
                    profile.UserName,
                    profile.AvatarUrl,
                    content.Message
                ),
            cancellationToken
        );
    }
}