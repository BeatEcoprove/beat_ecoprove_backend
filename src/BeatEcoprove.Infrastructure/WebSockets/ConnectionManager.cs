using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class ConnectionManager
{
    private readonly ConcurrentDictionary<Guid, WebSocket> _authUsers = new();
    public IReadOnlyDictionary<Guid, WebSocket> AuthUsers => _authUsers.AsReadOnly();
    
    public void AddUser(Guid userId, WebSocket socket)
    {
        _authUsers.TryAdd(userId, socket);
    }
    
    public async Task CloseByUserId(Guid userId, CancellationToken cancellationToken = default)
    {
        var socket = _authUsers[userId];
        
        await socket.CloseAsync(
            WebSocketCloseStatus.NormalClosure, 
            string.Empty, 
            cancellationToken);
        
        _authUsers.TryRemove(userId, out _);
    }
}