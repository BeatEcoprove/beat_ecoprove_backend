using BeatEcoprove.Application;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure;

public class ProfileRepository : Repository<Profile, ProfileId>, IProfileRepository
{
    public ProfileRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken)
    {
        return await _dbContext
            .Profiles
            .AnyAsync(p => p.UserName == userName, cancellationToken);
    }

    public async Task<Profile?> GetProfileByAuthId(AuthId id, CancellationToken cancellationToken)
    {
        return await
            _dbContext
            .Profiles
            .SingleOrDefaultAsync(p => p.AuthId == id, cancellationToken);
    }
}
