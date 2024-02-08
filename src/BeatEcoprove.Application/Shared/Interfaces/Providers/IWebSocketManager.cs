using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Net.WebSockets;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IWebSocketManager
{
    Task Handle(WebSocket webSocket, ProfileId userId, CancellationToken cancellationToken = default);
}