using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class SessionManager : ISessionManager
{
    private readonly ConcurrentDictionary<ProfileId, WebSocket> _users = new();

    public void Add(ProfileId userId, WebSocket? value = null)
    {
        ArgumentNullException.ThrowIfNull(userId, nameof(userId));
        _users.TryAdd(userId, value!);
    }

    public async Task CloseAsync(ProfileId userId, WebSocketCloseStatus status, string reason, CancellationToken cancellation = default)
    {
        var socket = _users[userId];

        if (socket.State != WebSocketState.Aborted)
        {
            await socket.CloseAsync(
                status,
                reason,
                cancellation);
        }

        _users.TryRemove(userId, out _);
    }

    public async Task CloseAsync(ProfileId userId, CancellationToken cancellation = default)
    {
        await CloseAsync(
            userId,
            WebSocketCloseStatus.NormalClosure,
            string.Empty,
            cancellation);
    }

    public WebSocket? Get(ProfileId userId)
    {
        return _users.GetValueOrDefault(userId);
    }

    public bool IsUserAuthenticated(ProfileId userId)
    {
        return Get(userId) != null;
    }
}
