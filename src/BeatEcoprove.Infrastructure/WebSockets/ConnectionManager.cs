using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace BeatEcoprove.Infrastructure.WebSockets;

public record GroupMember(Guid UserId, WebSocket Socket);

public class ConnectionManager
{
    private readonly ConcurrentDictionary<Guid, WebSocket> _authUsers = new();
    private readonly ConcurrentDictionary<Guid, List<GroupMember>> _groups = new();
    
    public IReadOnlyDictionary<Guid, WebSocket> AuthUsers => _authUsers.AsReadOnly();
    public IReadOnlyDictionary<Guid, List<GroupMember>> Groups => _groups.AsReadOnly();
    
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
    
    public List<GroupMember>? GetGroup(Guid groupId, CancellationToken cancellationToken)
    {
        return _groups.GetValueOrDefault(groupId);
    }
    
    public List<GroupMember> RegisterGroup(Guid groupId)
    {
        _groups.TryAdd(groupId, new ());
        
        return _groups[groupId];
    }
    
    public async Task<bool> AddToGroup(Guid groupId, Guid userId, WebSocket socket)
    {
        if (!_groups.TryGetValue(groupId, out var sockets))
        {
            _groups.TryAdd(groupId, new());
        }

        if (sockets is null)
        {
            return false;
        }
        
        var user = sockets.FirstOrDefault(x => x.UserId == userId);

        if (user is not null)
        {
            if (user.Socket == socket)
            {
                return false;
            }
            
            await CloseUserByGroupId(groupId, userId);
        }

        sockets.Add(new GroupMember(userId, socket));
        return true;
    }
    
    public async Task CloseUserByGroupId(Guid groupId, Guid userId, CancellationToken cancellationToken = default)
    {
        var user = _groups[groupId].First(x => x.UserId == userId);
        
        await user.Socket.CloseAsync(
            WebSocketCloseStatus.NormalClosure, 
            string.Empty, 
            cancellationToken);
        
        _groups[groupId].Remove(user);
    }
}