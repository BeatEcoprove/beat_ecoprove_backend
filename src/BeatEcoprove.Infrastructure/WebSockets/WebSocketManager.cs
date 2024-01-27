using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Infrastructure.WebSockets.Handlers;

namespace BeatEcoprove.Infrastructure.WebSockets;
public class WebSocketManager : IWebSocketManager
{
    private readonly AuthenticationHandler _authenticationHandler;
    private readonly ChatGroupHandler _chatGroupHandler;

    public WebSocketManager(
        AuthenticationHandler authenticationHandler, 
        ChatGroupHandler chatGroupHandler)
    {
        _authenticationHandler = authenticationHandler;
        _chatGroupHandler = chatGroupHandler;
    }

    public async Task Handle(WebSocket webSocket, Guid userId, CancellationToken cancellationToken = default)
    {
        var buffer = new byte[1024 * 4];
        var messageBuilder = new StringBuilder();

        try
        {
            while (webSocket.State == WebSocketState.Open)
            {
                var receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);
                
                if (webSocket.State == WebSocketState.Closed)
                {
                    break;
                }

                messageBuilder.Append(Encoding.UTF8.GetString(buffer, 0, receiveResult.Count));

                if (receiveResult.EndOfMessage)
                {
                    var jsonMessage = messageBuilder.ToString();
                    messageBuilder.Clear();
                    await HandleMessageAsync(new WebSocketMessage(webSocket, userId, jsonMessage), cancellationToken);
                }
            }
        }
        finally
        {
            if (webSocket.State != WebSocketState.Closed)
                await webSocket.CloseAsync(
                    WebSocketCloseStatus.InternalServerError, 
                    "Server error", 
                    cancellationToken);

            webSocket.Dispose();
        }
    }

    private async Task HandleMessageAsync(WebSocketMessage message, CancellationToken cancellationToken = default)
    {
        switch (message.Type)
        {
            case WbSocketType.Auth:
                await _authenticationHandler.Handle(message, cancellationToken);
                break;
            case WbSocketType.ConnectToGroup:
                await _chatGroupHandler.HandleConnectToGroup(message, cancellationToken);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}