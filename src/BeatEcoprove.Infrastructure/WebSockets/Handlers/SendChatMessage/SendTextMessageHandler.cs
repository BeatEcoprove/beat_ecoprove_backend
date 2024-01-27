using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Notifications;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers.SendChatMessage;

public class SendTextMessageHandler : ChatGroupWebSocketHandler
{
    private readonly IUnitOfWork _unitOfWork;
    
    public SendTextMessageHandler(
        ConnectionManager connectionManager, 
        IProfileRepository profileRepository, 
        IGroupRepository groupRepository, 
        IUnitOfWork unitOfWork) 
    : base(connectionManager, profileRepository, groupRepository)
    {
        _unitOfWork = unitOfWork;
    }

    public override async Task Handle(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        if (!ConnectionManager.AuthUsers.ContainsKey(message.UserId))
        {
            throw new Exception("Not Authenticated User");
        }
        
        var content = message.GetContent<SendTextMessage>();
        
        if (content is null)
        {
            return;
        }
        
        var socketGroup = 
            ConnectionManager
                .Groups
                .FirstOrDefault(group => group.Key == content.GroupId)
                .Value;
        
        if (socketGroup is null)
        {
            throw new Exception("There isn't any group with this id");
        }
        
        if (socketGroup.All(user => user.UserId != message.UserId))
        {
            throw new Exception("Not Connected To Any Group");
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