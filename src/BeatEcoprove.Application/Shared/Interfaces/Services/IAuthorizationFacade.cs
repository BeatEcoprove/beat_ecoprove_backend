using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IAuthorizationFacade
{
    Task<ErrorOr<Profile>> GetAuthProfileByEmailAsync(string email, CancellationToken cancellationToken = default);
}