using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IAuthRepository : IRepository<Auth, AuthId>
{
    Task<bool> ExistsUserByEmailAsync(Email value, CancellationToken cancellationToken = default);
    Task<bool> ExistsUserByIdAsync(AuthId authId, CancellationToken cancellationToken = default);
    Task<Profile?> GetMainProfile(AuthId id, CancellationToken cancellationToken = default);
    Task<Auth?> GetAuthByEmail(Email value, CancellationToken cancellationToken);
    Task UpdateUserPassword(AuthId id, Password hashedPassword, CancellationToken cancellationToken);
    Task<bool> DoesProfileBelongToAuth(AuthId authId, ProfileId profileId, CancellationToken cancellationToken);
}
