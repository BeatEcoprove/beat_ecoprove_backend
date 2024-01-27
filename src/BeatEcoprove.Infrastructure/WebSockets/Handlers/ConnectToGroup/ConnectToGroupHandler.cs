using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Notifications;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers.ConnectToGroup;

public class ConnectToGroupHandler : ChatGroupWebSocketHandler
{
    public ConnectToGroupHandler(
        ConnectionManager connectionManager, 
        IProfileRepository profileRepository, 
        IGroupRepository groupRepository) 
    : base(connectionManager, profileRepository, groupRepository)
    {
    }

    public override async Task Handle(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        if (!ConnectionManager.AuthUsers.ContainsKey(message.UserId))
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

        if (ConnectionManager.GetGroup(content.GroupId, cancellationToken) == null)
        {
            ConnectionManager.RegisterGroup(content.GroupId);
        }
        
        var shouldAddToGroup = await ConnectionManager.AddToGroup(content.GroupId, message.UserId, message.Socket);
        
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
}