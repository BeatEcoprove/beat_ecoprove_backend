using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.UserAggregator;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IApplicationDbContext _dbContext;

    public UserRepository(IApplicationDbContext applicationDbContext)
    {
        _dbContext = applicationDbContext;
    }

    public async Task AddAsync(User entity, CancellationToken cancellationToken = default)
    {
        await _dbContext.Users.AddAsync(entity, cancellationToken);
    }

    public async Task<User?> GetByIdAsync(UserId id, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Users
            .SingleOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public Task<User?> UpdateByIdAsync(UserId id, User entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> ExistsUserByEmailAsync(Email email, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Users
            .AnyAsync(user => user.Email == email, cancellationToken);
    }

    public async Task<User?> GetUserByEmail(Email email, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Users
            .SingleOrDefaultAsync(user => user.Email == email, cancellationToken);
    }

    public async Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Users
            .OfType<Consumer>()
            .SelectMany(consumer => consumer.Profiles)
            .AnyAsync(profile => profile.UserName == userName, cancellationToken);
    }

    public async Task<List<Consumer>> JustPleaseWork(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Users
          .OfType<Consumer>() // or .OfType<Organization>() to get specific types
          .ToListAsync(cancellationToken);
    }
}