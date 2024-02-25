using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Net.WebSockets;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public interface ISessionManager : IConnectionManager<ProfileId, WebSocket>
{
    bool IsUserAuthenticated(ProfileId userId);
    Task CloseAsync(ProfileId userId, WebSocketCloseStatus status, string reason, CancellationToken cancellation = default);
    WebSocket Delete(ProfileId userId);
}
