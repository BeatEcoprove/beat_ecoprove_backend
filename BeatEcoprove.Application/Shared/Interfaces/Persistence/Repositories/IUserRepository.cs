using BeatEcoprove.Domain.UserAggregator;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IUserRepository : IRepository<User, UserId>
{
    Task<bool> ExistsUserByEmailAsync(Email email, CancellationToken cancellationToken = default);
    Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken = default);
    Task<User?> GetUserByEmail(Email email, CancellationToken cancellationToken = default);
    Task UpdateUserPassword(UserId userId, Password password, CancellationToken cancellationToken = default);
}