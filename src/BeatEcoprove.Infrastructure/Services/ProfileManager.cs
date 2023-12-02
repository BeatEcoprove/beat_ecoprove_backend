using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class ProfileManager : IProfileManager
{
    private readonly IAuthorizationFacade _authorizationFacade;

    public ProfileManager(IAuthorizationFacade authorizationFacade)
    {
        _authorizationFacade = authorizationFacade;
    }

    public async Task<ErrorOr<Profile>> GetProfileAsync(Guid authId, Guid? profileId = null, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;
        return Errors.User.ProfileDoesNotExists;
    }
}