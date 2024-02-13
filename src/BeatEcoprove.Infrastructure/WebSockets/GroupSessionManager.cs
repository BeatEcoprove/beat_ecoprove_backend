using BeatEcoprove.Application.Shared.Communication;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.Extensions.Options;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace BeatEcoprove.Infrastructure.WebSockets;

public class GroupSessionManager : IGroupSessionManager
{
    private ConcurrentDictionary<GroupId, List<Member>> _groups = new();
    private readonly JsonSerializerOptions _options;

    public GroupSessionManager(IOptions<JsonSerializerOptions> options)
    {
        _options = options.Value;
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
            .FirstOrDefault(x => x.Id == member.Id);

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

            sockets.Remove(foundMember);
        }

        sockets.Add(member);
        _groups.TryAdd(groupId, sockets);
    }

    public async Task RemoveMember(GroupId groupId, ProfileId memberId, CancellationToken cancellation = default)
    {
        var user = _groups[groupId].FirstOrDefault(x => x.Id == memberId);

        if (user is null)
        {
            return;
        }

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

    public async Task SendEveryoneAsync(
        GroupId groupId, 
        IRealTimeNotification notification, 
        CancellationToken cancellationToken = default)
    {
        var users = Get(groupId)!;

        if (users is null)
        {
            return;
        }

        var responseBytes = Encoding.UTF8.GetBytes(notification.ConvertToJson(_options));
        await Task.WhenAll(users.Select(user => user.Socket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
            WebSocketMessageType.Text,
            true,
            cancellationToken)));
    }

    public bool IsUserMemberOfAnyGroup(ProfileId userId)
    {
        foreach (var group in _groups.Values)
        {
            if (group.Any(member => member.Id == userId))
            {
                return true;
            }
        }

        return false;
    }
}
