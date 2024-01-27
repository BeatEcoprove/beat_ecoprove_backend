using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers;

public class AuthenticationHandler : WebSocketHandler, INotificationSender
{
    public AuthenticationHandler(ConnectionManager connectionManager) : base(connectionManager)
    {
    }

    public override async Task Handle(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        if (ConnectionManager.AuthUsers.TryGetValue(message.UserId, out var socket))
        {
            if (message.Socket == socket)
            {
                return;
            }
                
            await ConnectionManager.CloseByUserId(message.UserId, cancellationToken);
        }
        
        ConnectionManager.AddUser(message.UserId, message.Socket);
    }

    public async Task SendNotificationAsync(
        Guid userId, 
        SendNotification notification, 
        CancellationToken cancellationToken = default)
    {
        if (ConnectionManager.AuthUsers.TryGetValue(userId, out var userWebSocket))
        {
            var responseBytes = Encoding.UTF8.GetBytes(notification);
            await userWebSocket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
                WebSocketMessageType.Text,
                true,
                cancellationToken);
        }
    }
}