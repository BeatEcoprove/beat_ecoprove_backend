using BeatEcoprove.Application;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class ProfileManager : IProfileManager
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;

    public ProfileManager(
        IAuthRepository authRepository, 
        IProfileRepository profileRepository)
    {
        _authRepository = authRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<Profile>> GetProfileAsync(Guid authId, Guid profileId, CancellationToken cancellationToken = default)
    {
        Profile? profile;
        var strongAuthId = AuthId.Create(authId);

        if (!await _authRepository.ExistsUserByIdAsync(strongAuthId, cancellationToken))
        {
            return Errors.Auth.InvalidAuth;
        }

        if (profileId == Guid.Empty)
        {
            profile = await _authRepository.GetMainProfile(strongAuthId, cancellationToken);
        }
        else
        {
            profile = await _profileRepository.GetByIdAsync(ProfileId.Create(profileId), cancellationToken);
        }
            
        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }
        
        return profile;
    }
}