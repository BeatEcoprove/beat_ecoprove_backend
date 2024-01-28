using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class FeedBackRepository : Repository<FeedBack, FeedBackId>, IFeedBackRepository
{
    public FeedBackRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}