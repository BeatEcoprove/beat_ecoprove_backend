using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IGroupRepository : IRepository<Group, GroupId>
{
    public Task<List<Group>> GetPublicGroupsAsync(ProfileId profileId, string? search, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default);
    public Task<List<Group>> GetPrivateGroupsAsync(ProfileId profileId, string? search, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default);
    Task<bool> IsMemberAsync(Guid groupId, ProfileId profileId, CancellationToken cancellationToken);
    Task<GroupDao?> GetGroupDaoAsync(GroupId groupId, CancellationToken cancellationToken);
    Task<bool> IsProfileAdminOrOwnerAsync(GroupId groupId, ProfileId profileId, CancellationToken cancellationToken);
    Task RemoveGroupAsync(Group group, CancellationToken cancellationToken);
    Task<GroupInvite?> GetGroupInviteAsync(GroupId groupId, InviteGroupId inviteId, CancellationToken cancellationToken);
    Task<Dictionary<GroupMemberId, Profile>> GetMemberProfiles(GroupId id, List<GroupMemberId> memberIds, CancellationToken cancellationToken = default);
}