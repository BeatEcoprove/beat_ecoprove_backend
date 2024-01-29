using System.Net.WebSockets;
using System.Text;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Infrastructure.WebSockets.Handlers;
using BeatEcoprove.Infrastructure.WebSockets.Handlers.Authentication;
using BeatEcoprove.Infrastructure.WebSockets.Handlers.ConnectToGroup;
using BeatEcoprove.Infrastructure.WebSockets.Handlers.SendChatMessage;

namespace BeatEcoprove.Infrastructure.WebSockets;
public class WebSocketManager : IWebSocketManager
{
    private readonly AuthenticationHandler _authenticationHandler;
    private readonly ConnectToGroupHandler _connectToGroupHandler;
    private readonly SendTextMessageHandler _sendTextMessageHandler;

    public WebSocketManager(
        AuthenticationHandler authenticationHandler, 
        ConnectToGroupHandler connectToGroupHandler, 
        SendTextMessageHandler sendTextMessageHandler)
    {
        _authenticationHandler = authenticationHandler;
        _connectToGroupHandler = connectToGroupHandler;
        _sendTextMessageHandler = sendTextMessageHandler;
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
                
                if (webSocket.State == WebSocketState.Closed || webSocket.State == WebSocketState.CloseReceived)
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
                    WebSocketCloseStatus.NormalClosure, 
                    string.Empty, 
                    cancellationToken);

            webSocket.Dispose();
        }
    }

    private async Task HandleMessageAsync(
        WebSocketMessage message, 
        CancellationToken cancellationToken = default)
    {
        switch (message.Type)
        {
            case WbSocketType.Auth:
                await _authenticationHandler.Handle(message, cancellationToken);
                break;
            case WbSocketType.ConnectToGroup:
                await _connectToGroupHandler.Handle(message, cancellationToken);
                break;
            case WbSocketType.SendTextMessage:
                await _sendTextMessageHandler.Handle(message, cancellationToken);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}