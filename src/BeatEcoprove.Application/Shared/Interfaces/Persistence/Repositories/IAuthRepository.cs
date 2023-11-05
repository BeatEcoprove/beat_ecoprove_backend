using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application;

public interface IAuthRepository
{
    Task AddAsync(Auth auth, CancellationToken cancellationToken);
    Task<bool> ExistsUserByEmailAsync(Email value, CancellationToken cancellationToken = default);
    Task<Auth?> GetAuthByEmail(Email value, CancellationToken cancellationToken);
    Task UpdateUserPassword(AuthId id, Password hashedPassword, CancellationToken cancellationToken);
}
