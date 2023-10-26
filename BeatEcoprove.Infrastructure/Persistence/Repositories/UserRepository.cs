using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.UserAggregator;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    
    public async Task AddAsync(User entity, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;
        _users.Add(entity);
    }

    public async Task<User?> GetByIdAsync(UserId id, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;
        return _users.SingleOrDefault(user => user.Id == id);
    }

    public Task<User?> UpdateByIdAsync(UserId id, User entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> ExistsUserByEmailAsync(Email email, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;
        return _users.Any(user => user.Email == email);
    }

    public async Task<User?> GetUserByEmail(Email email, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;
        return _users
            .SingleOrDefault(user => user.Email == email);
    }
}