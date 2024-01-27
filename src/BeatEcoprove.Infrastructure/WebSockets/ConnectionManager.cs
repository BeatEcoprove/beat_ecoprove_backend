using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class ConnectionManager
{
    private readonly ConcurrentDictionary<Guid, WebSocket> _authUsers = new();
    private readonly ConcurrentDictionary<Guid, List<WebSocket>> _groups = new();
    
    public IReadOnlyDictionary<Guid, WebSocket> AuthUsers => _authUsers.AsReadOnly();
    public IReadOnlyDictionary<Guid, List<WebSocket>> Groups => _groups.AsReadOnly();
    
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
    
    public List<WebSocket>? GetGroup(Guid groupId, CancellationToken cancellationToken)
    {
        return _groups.GetValueOrDefault(groupId);
    }
    
    public List<WebSocket> RegisterGroup(Guid groupId, WebSocket incomingUser)
    {
        _groups.TryAdd(groupId, new List<WebSocket> { incomingUser });
        
        return _groups[groupId];
    }
    
    public void AddToGroup(Guid groupId, WebSocket socket)
    {
        if (!_groups.TryGetValue(groupId, out var sockets))
        {
            sockets = new List<WebSocket>();
            _groups.TryAdd(groupId, sockets);
        }
        
        sockets.Add(socket);
    }

}