using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class GroupRepository : Repository<Group, GroupId>, IGroupRepository
{
    public GroupRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public new Task<Group?> GetByIdAsync(GroupId id, CancellationToken cancellationToken = default)
    {
        return DbContext.Set<Group>()
            .Include(group => group.Members)
            .Include(group => group.Invites)
            .FirstOrDefaultAsync(group => group.Id == id, cancellationToken);
    }

    public async Task<List<Group>> GetPublicGroupsAsync(
        ProfileId profileId,
        string? search,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var getPublicGroups =
            from groupEntity in DbContext.Set<Group>()
            where
                groupEntity.IsPublic && groupEntity.CreatorId != profileId &&
                (search == null || groupEntity.Name.ToLower().Contains(search.ToLower()))
            select groupEntity;

        getPublicGroups = getPublicGroups
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await getPublicGroups.ToListAsync(cancellationToken);
    }

    public async Task<List<Group>> GetPrivateGroupsAsync(
        ProfileId profileId,
        string? search,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var getPrivateGroups =
            from groupEntity in DbContext.Set<Group>()
            from groupMember in groupEntity.Members
            join profile in DbContext.Profiles
                on groupMember.Profile equals profile.Id
            where
                profile.Id == profileId &&
                (search == null || groupEntity.Name.ToLower().Contains(search.ToLower()))
            select groupEntity;

        getPrivateGroups = getPrivateGroups
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await getPrivateGroups.ToListAsync(cancellationToken);
    }

    public async Task<bool> IsMemberAsync(Guid groupId, ProfileId profileId, CancellationToken cancellationToken)
    {
        var isMemberOfGroup =
            from groupEntity in DbContext.Set<Group>()
            from groupMember in groupEntity.Members
            join profile in DbContext.Profiles
                on groupMember.Profile equals profile.Id
            where
                (profile.Id == profileId && groupEntity.Id == groupId) ||
                (groupEntity.IsPublic == true && groupEntity.Id == groupId)
            select profile;

        return await isMemberOfGroup.AnyAsync(cancellationToken);
    }

    public async Task<GroupDao?> GetGroupDaoAsync(GroupId groupId, CancellationToken cancellationToken)
    {
        var getGroupDao =
            from groupEntity in DbContext.Set<Group>()
            where groupEntity.Id == groupId
            select new GroupDao(
                groupEntity.Id,
                groupEntity.Name,
                groupEntity.Description,
                groupEntity.MembersCount,
                groupEntity.SustainablePoints,
                groupEntity.Xp,
                groupEntity.IsPublic,
                groupEntity.AvatarPicture,
                (
                    from groupMember in groupEntity.Members
                    join profile in DbContext.Profiles
                        on groupMember.Profile equals profile.Id
                    where groupEntity.CreatorId == profile.Id
                    select profile
                ).FirstOrDefault()!,
                (
                    from groupMember in groupEntity.Members
                    join profile in DbContext.Profiles
                        on groupMember.Profile equals profile.Id
                    select profile
                ).ToList(),
                (
                    from groupMember in groupEntity.Members
                    join profile in DbContext.Profiles
                        on groupMember.Profile equals profile.Id
                    where groupMember.Permission == MemberPermission.Admin
                    select profile
                ).ToList()
            );


        return await getGroupDao.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<bool> IsProfileAdminOrOwnerAsync(GroupId groupId, ProfileId profileId, CancellationToken cancellationToken)
    {
        var isAdminOrOwnerOfGroup =
            from groupEntity in DbContext.Set<Group>()
            from groupMember in groupEntity.Members
            join profile in DbContext.Profiles
                on groupMember.Profile equals profile.Id
            where groupEntity.CreatorId == profileId ||
                  (groupMember.Permission == MemberPermission.Admin && groupEntity.Id == groupId)
            select profile;

        return await isAdminOrOwnerOfGroup.AnyAsync(cancellationToken);
    }

    public async Task RemoveGroupAsync(Group group, CancellationToken cancellationToken)
    {
        var groupEntity = await DbContext
            .Set<Group>()
            .SingleOrDefaultAsync(groupEntity => groupEntity.Id == group.Id, cancellationToken);

        if (groupEntity is null)
        {
            throw new Exception("Cloth not found");
        }

        DbContext.Set<Group>().Remove(groupEntity);
    }

    public Task<GroupInvite?> GetGroupInviteAsync(GroupId groupId, InviteGroupId inviteId, CancellationToken cancellationToken)
    {
        var getGroupInvite =
            from groupEntity in DbContext.Set<Group>()
            from groupInvite in groupEntity.Invites
            where groupEntity.Id == groupId && groupInvite.Id == inviteId
            select groupInvite;
        
        return getGroupInvite.FirstOrDefaultAsync(cancellationToken);
    }

    public Task<bool> InvitationExists(InviteGroupId invitationId, CancellationToken cancellationToken)
    {
        return DbContext.Set<GroupInvite>()
            .AnyAsync(invite => invite.Id == invitationId, cancellationToken);
    }

    public Task<Dictionary<GroupMemberId, Profile>> GetMemberProfiles
        (GroupId id, List<GroupMemberId> memberIds, CancellationToken cancellationToken = default)
    {
        var getMemberProfiles =
        from groupEntity in DbContext.Set<Group>()
        from member in groupEntity.Members
        join profile in DbContext.Profiles on member.Profile equals profile.Id
        where
            groupEntity.Id == id && memberIds.Contains(member.Id)
        select new { member.Id, Profile = profile };

        return getMemberProfiles
            .IgnoreQueryFilters()
            .ToDictionaryAsync(x => x.Id, x => x.Profile, cancellationToken);
    }
}