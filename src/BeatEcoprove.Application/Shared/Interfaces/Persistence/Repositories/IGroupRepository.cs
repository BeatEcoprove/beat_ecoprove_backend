using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IGroupRepository : IRepository<Group, GroupId>
{
    public Task<List<Group>> GetPublicGroupsAsync(CancellationToken cancellationToken = default);
    public Task<List<Group>> GetPrivateGroupsAsync(ProfileId profileId, CancellationToken cancellationToken = default);
}