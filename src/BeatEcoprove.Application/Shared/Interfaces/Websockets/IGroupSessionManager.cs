﻿using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Net.WebSockets;
using System.Text;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public interface IGroupSessionManager : IConnectionManager<GroupId, List<Member>>
{
    Task AddMember(GroupId groupId, Member member, CancellationToken cancellation = default);
    Task RemoveMember(GroupId groupId, ProfileId memberId, CancellationToken cancellation = default);
    Task SendEveryoneAsync(GroupId groupId, SendNotification notification, CancellationToken cancellation = default);
}
