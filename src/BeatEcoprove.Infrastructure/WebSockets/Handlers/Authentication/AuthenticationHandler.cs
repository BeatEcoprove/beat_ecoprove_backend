using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Notifications;
using BeatEcoprove.Domain.Documents;
using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers.Authentication;

public class AuthenticationHandler : WebSocketHandler, INotificationSender
{
    private readonly IMongoCollection<Notification> _mongoCollection;
    
    public AuthenticationHandler(
        ConnectionManager connectionManager, 
        IMongoDatabase mongoDb) : base(connectionManager)
    {
        _mongoCollection = mongoDb.GetCollection<Notification>("notifications");
    }

    public override async Task Handle(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        if (ConnectionManager.AuthUsers.TryGetValue(message.UserId, out var socket))
        {
            if (message.Socket == socket)
            {
                return;
            }
                
            if (socket.State == WebSocketState.Open)
            { 
                await ConnectionManager.CloseByUserId(message.UserId, cancellationToken);
            }
            
            ConnectionManager.RemoveUser(message.UserId);
        }
        
        ConnectionManager.AddUser(message.UserId, message.Socket);
    }

    [Obsolete("Obsolete")]
    public async Task SendNotificationAsync(
        Guid userId, 
        SendNotification notification, 
        CancellationToken cancellationToken = default)
    {
        if (!ConnectionManager.AuthUsers.TryGetValue(userId, out var userWebSocket))
        {
           return;
        }
        
        var responseBytes = Encoding.UTF8.GetBytes(notification);
        await userWebSocket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
            WebSocketMessageType.Text,
            true,
            cancellationToken);

        if (notification is InviteToGroupNotification invite)
        {
            await _mongoCollection.InsertOneAsync(
                new Notification(
                    userId,
                    invite.Message,
                    Guid.Parse(invite.GroupId), 
                    Guid.Parse(invite.InvitorId),
                    invite.Code
                ), 
                cancellationToken);
        }
        
    }
}