using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain;
using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application;

public interface IAuthRepository
{
    Task AddAsync(Auth auth, CancellationToken cancellationToken);
    Task<bool> ExistsUserByEmailAsync(Email value, CancellationToken cancellationToken = default);
    Task<Auth?> GetAuthByEmail(Email value, CancellationToken cancellationToken);
    Task UpdateUserPassword(AuthId id, Password hashedPassword, CancellationToken cancellationToken);
}
