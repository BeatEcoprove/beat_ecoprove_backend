using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class GroupRepository : Repository<Group, GroupId>, IGroupRepository
{
    public GroupRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Group>> GetPublicGroupsAsync(
        ProfileId profileId, 
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var getPublicGroups =
            from groupEntity in DbContext.Set<Group>()
            where groupEntity.IsPublic && groupEntity.CreatorId != profileId
            select groupEntity;
        
        getPublicGroups = getPublicGroups
            .Skip((page - 1) * pageSize)
            .Take(pageSize);
        
        return await getPublicGroups.ToListAsync(cancellationToken);
    }

    public async Task<List<Group>> GetPrivateGroupsAsync(
        ProfileId profileId, 
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
                profile.Id == profileId
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
                ).FirstOrDefault(),
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
}
