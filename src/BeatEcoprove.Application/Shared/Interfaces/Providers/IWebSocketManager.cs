using System.Net.WebSockets;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IWebSocketManager
{
    Task Handle(WebSocket webSocket, Guid userId, CancellationToken cancellationToken = default);
}