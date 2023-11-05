using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application;

public interface IProfileRepository : IRepository<Profile, ProfileId>
{
    Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken);
    Task<Profile?> GetProfileByAuthId(AuthId id, CancellationToken cancellationToken);
}