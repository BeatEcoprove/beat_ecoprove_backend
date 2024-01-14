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
        
        if (!await _authRepository.DoesProfileBelongToAuth(strongAuthId, profile.Id, cancellationToken))
        {
            return Errors.User.ProfileDoesNotBelongToAuth;
        }
        
        return profile;
    }

    public async Task<ErrorOr<List<ProfileId>>> GetNestedProfileIds(Guid id, Guid mainProfileId, CancellationToken cancellationToken = default)
    {
        var authId = AuthId.Create(id);
        var profileId = ProfileId.Create(mainProfileId);
        
        if (!await _authRepository.ExistsUserByIdAsync(authId, cancellationToken))
        {
            return Errors.Auth.InvalidAuth;
        }

        var profile = await _authRepository.GetMainProfile(authId, cancellationToken);
        
        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }
        
        // If not main, then return only the profileId
        if (profile.Id != profileId)
        {
            return new List<ProfileId>() { profileId };
        }
        
        // if main, then return all nested profileIds
        return await _profileRepository.GetNestedProfileIds(authId, cancellationToken);
    }
}