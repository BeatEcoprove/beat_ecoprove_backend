using BeatEcoprove.Application;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class AuthRepository : Repository<Auth, AuthId>, IAuthRepository
{
    public AuthRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> ExistsUserByEmailAsync(Email value, CancellationToken cancellationToken = default)
    {
        return await DbContext.Auths
            .AnyAsync(auth => auth.Email == value, cancellationToken);
    }

    public async Task<Auth?> GetAuthByEmail(Email value, CancellationToken cancellationToken)
    {
        return await DbContext.Auths
            .SingleOrDefaultAsync(auth => auth.Email == value, cancellationToken);
    }

    public async Task<Profile?> GetProfileAsync(AuthId authId, CancellationToken cancellationToken = default)
    {
        return await DbContext.Auths
            .Where(auth => auth.Id == authId)
            .Join(DbContext.Profiles,
                auth => auth.Id,
                profile => profile.AuthId,
                (auth, profile) => profile)
            .SingleOrDefaultAsync(cancellationToken);
    }

    public async Task UpdateUserPassword(AuthId id, Password hashedPassword, CancellationToken cancellationToken)
    {
        await DbContext
           .Auths
           .Where(user => user.Id == id)
           .ExecuteUpdateAsync(setters => setters
               .SetProperty(p => p.Password, hashedPassword), cancellationToken);
    }

    public async Task<bool> DoesProfileBelongToAuth(AuthId authId, ProfileId profileId, CancellationToken cancellationToken)
    {
        return await DbContext
            .Profiles
            .Where(profile => profile.Id == profileId)
            .Where(profile => profile.AuthId == authId)
            .AnyAsync(cancellationToken);
    }
}
