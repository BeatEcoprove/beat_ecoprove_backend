using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class WebSocketHandler : IWebSocketsHandler
{
    private readonly ConcurrentDictionary<Guid, WebSocket> _connectedUsers = new();

    public async Task Handle(WebSocket webSocket, Guid userId)
    {
        if (_connectedUsers.TryGetValue(userId, out var socket))
        {
            await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
        }
        
        _connectedUsers.TryAdd(userId, webSocket);
        var buffer = new byte[1024 * 4];

        while (webSocket.State == WebSocketState.Open)
        {
            var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            if (result.MessageType != WebSocketMessageType.Close) continue;
            
            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
            _connectedUsers.TryRemove(userId, out _);
        }
    }

    public async Task SendNotificationToUser(Guid userId, SendNotification message)
    {
        if (_connectedUsers.TryGetValue(userId, out var userWebSocket))
        {
            var responseBytes = Encoding.UTF8.GetBytes(message);
            await userWebSocket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
                WebSocketMessageType.Text,
                true,
                CancellationToken.None);
        }
    }
}