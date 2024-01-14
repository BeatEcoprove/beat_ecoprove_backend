using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.GroupAggregator;
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

    public async Task<List<Group>> GetPublicGroupsAsync(CancellationToken cancellationToken = default)
    {
        var getPublicGroups =
            from groupEntity in DbContext.Set<Group>()
            where groupEntity.IsPublic
            select groupEntity;
        
        return await getPublicGroups.ToListAsync(cancellationToken);
    }

    public async Task<List<Group>> GetPrivateGroupsAsync(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        var getPrivateGroups =
            from groupEntity in DbContext.Set<Group>()
            from groupMember in groupEntity.Members
            join profile in DbContext.Profiles 
                on groupMember.Profile equals profile.Id
            where 
                groupEntity.IsPublic == false &&
                profile.Id == profileId
            select groupEntity;
        
        return await getPrivateGroups.ToListAsync(cancellationToken);
    }
}
