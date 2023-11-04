﻿using BeatEcoprove.Application;
using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure;

public class AuthRepository : Repository<Auth, AuthId>, IAuthRepository
{
    public AuthRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> ExistsUserByEmailAsync(Email value, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Auths
            .AnyAsync(auth => auth.Email == value, cancellationToken);
    }

    public async Task<Auth?> GetAuthByEmail(Email value, CancellationToken cancellationToken)
    {
        return await _dbContext.Auths
            .SingleOrDefaultAsync(auth => auth.Email == value, cancellationToken);
    }

    public async Task<Profile?> GetProfileAsync(AuthId authId, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Auths
            .Where(auth => auth.Id == authId)
            .Join(_dbContext.Profiles,
                auth => auth.Id,
                profile => profile.AuthId,
                (auth, profile) => profile)
            .SingleOrDefaultAsync(cancellationToken);
    }

    public async Task UpdateUserPassword(AuthId id, Password hashedPassword, CancellationToken cancellationToken)
    {
        await _dbContext
           .Auths
           .Where(user => user.Id == id)
           .ExecuteUpdateAsync(setters => setters
               .SetProperty(p => p.Password, hashedPassword), cancellationToken);
    }
}
