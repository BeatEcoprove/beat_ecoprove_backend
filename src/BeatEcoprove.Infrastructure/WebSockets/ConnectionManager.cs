using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class ConnectionManager
{
    private readonly ConcurrentDictionary<Guid, WebSocket> _authUsers = new();
    private readonly ConcurrentDictionary<Guid, List<(Guid, WebSocket)>> _groups = new();
    
    public IReadOnlyDictionary<Guid, WebSocket> AuthUsers => _authUsers.AsReadOnly();
    public IReadOnlyDictionary<Guid, List<(Guid, WebSocket)>> Groups => _groups.AsReadOnly();
    
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
    
    public List<(Guid, WebSocket)>? GetGroup(Guid groupId, CancellationToken cancellationToken)
    {
        return _groups.GetValueOrDefault(groupId);
    }
    
    public List<(Guid, WebSocket)> RegisterGroup(Guid groupId)
    {
        _groups.TryAdd(groupId, new ());
        
        return _groups[groupId];
    }
    
    public void AddToGroup(Guid groupId, Guid userId, WebSocket socket)
    {
        if (!_groups.TryGetValue(groupId, out var sockets))
        {
            _groups.TryAdd(groupId, new());
        }

        sockets?.Add((userId, socket));
    }
    
    public async Task CloseUserByGroupId(Guid groupId, Guid userId, CancellationToken cancellationToken = default)
    {
        var user = _groups[groupId].First(x => x.Item1 == userId);
        
        await user.Item2.CloseAsync(
            WebSocketCloseStatus.NormalClosure, 
            string.Empty, 
            cancellationToken);
        
        _groups[groupId].Remove(user);
    }
}