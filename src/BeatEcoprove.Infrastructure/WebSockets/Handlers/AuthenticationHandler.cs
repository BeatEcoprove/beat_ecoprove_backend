using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;

namespace BeatEcoprove.Infrastructure.WebSockets.Handlers;

public class AuthenticationHandler : INotificationSender
{
    private readonly ConnectionManager _connectionManager;

    public AuthenticationHandler(ConnectionManager connectionManager)
    {
        _connectionManager = connectionManager;
    }

    public async Task Handle(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        if (_connectionManager.AuthUsers.TryGetValue(message.UserId, out var socket))
        {
            if (message.Socket == socket)
            {
                return;
            }
                
            await _connectionManager.CloseByUserId(message.UserId, cancellationToken);
        }
        
        _connectionManager.AddUser(message.UserId, message.Socket);
    }

    public async Task SendNotificationAsync(
        Guid userId, 
        SendNotification notification, 
        CancellationToken cancellationToken = default)
    {
        if (_connectionManager.AuthUsers.TryGetValue(userId, out var userWebSocket))
        {
            var responseBytes = Encoding.UTF8.GetBytes(notification);
            await userWebSocket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
                WebSocketMessageType.Text,
                true,
                cancellationToken);
        }
    }
}