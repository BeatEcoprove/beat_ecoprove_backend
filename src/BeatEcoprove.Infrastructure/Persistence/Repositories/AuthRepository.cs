using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
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

    public async Task<bool> ExistsUserByIdAsync(AuthId authId, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Auths
            .AnyAsync(auth => auth.Id == authId, cancellationToken);
    }

    public async Task<Profile?> GetMainProfile(AuthId id, CancellationToken cancellationToken = default)
    {
        var getMainProfile =
            from auth in DbContext.Auths
            join profile in DbContext.Profiles on auth.Id equals profile.AuthId
            where auth.MainProfileId == profile.Id && auth.Id == id
            select profile;

        return await getMainProfile.SingleOrDefaultAsync(cancellationToken);
    }

    public async Task<Auth?> GetAuthByEmail(Email value, CancellationToken cancellationToken)
    {
        return await DbContext.Auths
            .SingleOrDefaultAsync(auth => auth.Email == value, cancellationToken);
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

    public async Task<bool> RemoveAuthProfileAsync(Profile workerProfile, CancellationToken cancellationToken)
    {
        var foundProfile = await DbContext.Set<Profile>()
            .FirstOrDefaultAsync(f => f.Id == workerProfile.Id, cancellationToken);

        if (foundProfile is null)
        {
            return false;
        }

        var foundAuth = await DbContext.Set<Auth>()
            .FirstOrDefaultAsync(a => a.MainProfileId == workerProfile.Id, cancellationToken: cancellationToken);

        if (foundAuth is null)
        {
            return false;
        }

        DbContext.Set<Profile>()
            .Remove(foundProfile);
        
        DbContext.Set<Auth>()
            .Remove(foundAuth);
        
        return true;
    }
}