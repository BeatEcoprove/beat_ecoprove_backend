using BeatEcoprove.Application.Shared.Communication;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public interface IGroupSessionManager : IConnectionManager<GroupId, List<Member>>
{
    bool IsUserMemberOfAnyGroup(ProfileId userId);
    Task AddMember(GroupId groupId, Member member, CancellationToken cancellation = default);
    Task RemoveMember(GroupId groupId, ProfileId memberId, CancellationToken cancellation = default);
    GroupId? GetGroupOfConnectedMember(ProfileId profileId, CancellationToken cancellationToken = default);
    Task SendEveryoneAsync(
        GroupId groupId,
        IRealTimeNotification notification,
        CancellationToken cancellation = default);
}