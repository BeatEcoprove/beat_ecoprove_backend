using System.Net.WebSockets;
using System.Text;
using System.Text.Json.Serialization;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Notifications;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers;

public class ConnectToGroupMessage
{
    [JsonPropertyName("groupId")]
    public Guid GroupId { get; init; }
}

public class ChatGroupHandler
{
    private readonly ConnectionManager _connectionManager;
    private readonly IServiceProvider _serviceProvider;

    public ChatGroupHandler(
        ConnectionManager connectionManager, 
        IServiceProvider serviceProvider)
    {
        _connectionManager = connectionManager;
        _serviceProvider = serviceProvider;
    }
    
    private async Task<bool> CheckIfGroupExistsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var groupId = GroupId.Create(id);
        
        using var scope = _serviceProvider.CreateScope();
        var groupRepository = scope.ServiceProvider.GetRequiredService<IGroupRepository>();

        var group = await groupRepository.GetByIdAsync(groupId, cancellationToken);

        return group != null;
    }
    
    public async Task<Profile?> GetProfileAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var profileId = ProfileId.Create(userId);
        using var scope = _serviceProvider.CreateScope();
        var profileRepository = scope.ServiceProvider.GetRequiredService<IProfileRepository>();

        return await profileRepository.GetByIdAsync(profileId, cancellationToken);
    }
    
    public async Task SendEveryoneAsync(Guid groupId, SendNotification notification, CancellationToken cancellationToken = default)
    {
        var users = _connectionManager.GetGroup(groupId, cancellationToken)!;
        
        if (users is null)
        {
            return;
        }
        
        var responseBytes = Encoding.UTF8.GetBytes(notification);
        await Task.WhenAll(users.Select(user => user.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
            WebSocketMessageType.Text,
            true,
            cancellationToken)));
    }
    
    public async Task HandleConnectToGroup(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        // Verify if user is authenticated
        if (!_connectionManager.AuthUsers.ContainsKey(message.UserId))
        {
            throw new Exception("Not Authenticated User");
        }
        
        // Get ConnectToGroupMessage content
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
        
        // Verify if group exists on database
        if (!await CheckIfGroupExistsAsync(content.GroupId, cancellationToken))
        {
            return;
        }

        // register group with an user
        if (_connectionManager.GetGroup(content.GroupId, cancellationToken) == null)
        {
            _connectionManager.RegisterGroup(content.GroupId, message.Socket);
        }
        
        // announce to group that user is connected
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
}