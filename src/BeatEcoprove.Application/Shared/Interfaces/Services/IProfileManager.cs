using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IProfileManager
{
    Task<ErrorOr<Profile>> GetProfileAsync(Guid authId, Guid? profileId = null,
        CancellationToken cancellationToken = default);
}