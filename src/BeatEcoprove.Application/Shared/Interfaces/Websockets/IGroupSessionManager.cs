using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public interface IGroupSessionManager : IConnectionManager<GroupId, List<Member>>
{
    Task AddMember(GroupId groupId, Member member, CancellationToken cancellation = default);
    Task RemoveMember(GroupId groupId, AuthId memberId, CancellationToken cancellation = default);
}
