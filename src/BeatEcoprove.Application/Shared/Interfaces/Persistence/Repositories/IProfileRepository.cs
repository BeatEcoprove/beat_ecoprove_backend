using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IProfileRepository : IRepository<Profile, ProfileId>
{
    Task<bool> ExistsUserByUserNameAsync(UserName userName, CancellationToken cancellationToken = default);
    Task<Profile?> GetProfileByAuthId(AuthId id, CancellationToken cancellationToken = default);
}