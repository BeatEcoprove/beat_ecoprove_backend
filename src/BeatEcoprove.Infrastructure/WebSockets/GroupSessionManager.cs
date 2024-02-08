using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class GroupSessionManager : IGroupSessionManager
{
    private readonly ISessionManager _sessionManager;
    private ConcurrentDictionary<GroupId, List<Member>> _groups = new();

    public GroupSessionManager(ISessionManager sessionManager)
    {
        _sessionManager = sessionManager;
    }

    public void Add(GroupId key, List<Member>? members = null)
    {
        if (members is null)
        {
            members = new() { };
        }

        _groups.TryAdd(key, members);
    }

    public async Task AddMember(GroupId groupId, Member member, CancellationToken cancellation = default)
    {
        if (!_groups.TryGetValue(groupId, out var sockets))
        {
            sockets = new() { };
        }

        var foundMember = sockets
            .FirstOrDefault(member => member.Id == member.Id);

        if (foundMember is not null)
        {
            if (foundMember.Socket == member.Socket)
            {
                return;
            }

            if (foundMember.Socket.State == WebSocketState.Open)
            {
                await RemoveMember(groupId, member.Id, cancellation);
            }

            sockets.Remove(member);
        }

        sockets.Add(member);
        _groups.TryAdd(groupId, sockets);
    }

    public async Task RemoveMember(GroupId groupId, AuthId memberId, CancellationToken cancellation = default)
    {
        var user = _groups[groupId].First(x => x.Id == memberId);

        await user.Socket.CloseAsync(
            WebSocketCloseStatus.NormalClosure,
        string.Empty,
            cancellation);

        _groups[groupId].Remove(user);
    }

    public async Task CloseAsync(GroupId groupId, CancellationToken cancellation = default)
    {
        var sockets = _groups[groupId];

        await Task.WhenAll(sockets.Select(socket =>
        {
            return socket.Socket.CloseAsync(
               WebSocketCloseStatus.NormalClosure,
               string.Empty,
               cancellation
             );
        }));

        _groups.TryRemove(groupId, out _);
    }

    public List<Member>? Get(GroupId groupId)
    {
        return _groups.GetValueOrDefault(groupId);
    }
}
