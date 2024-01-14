using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class GroupRepository : Repository<Group, GroupId>, IGroupRepository
{
    public GroupRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
