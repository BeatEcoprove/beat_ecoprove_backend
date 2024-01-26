using System.Net.WebSockets;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IWebSocketsHandler
{
    Task Handle(WebSocket webSocket, Guid userId);
    Task SendNotificationToUser(Guid userId, SendNotification message);
}