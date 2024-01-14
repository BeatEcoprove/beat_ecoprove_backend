using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IGroupRepository : IRepository<Group, GroupId>
{
    public Task<List<Group>> GetPublicGroupsAsync(CancellationToken cancellationToken = default);
    public Task<List<Group>> GetPrivateGroupsAsync(ProfileId profileId, CancellationToken cancellationToken = default);
    Task<bool> IsMemberAsync(Guid groupId, ProfileId profileId, CancellationToken cancellationToken);
    Task<GroupDao?> GetGroupDaoAsync(GroupId groupId, CancellationToken cancellationToken);
}