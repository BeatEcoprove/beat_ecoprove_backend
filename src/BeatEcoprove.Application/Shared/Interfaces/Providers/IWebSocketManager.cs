using System.Net.WebSockets;

using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IWebSocketManager : IRealTimeConnection
{
    Task Handle(WebSocket webSocket, ProfileId userId, CancellationToken cancellationToken = default);
}