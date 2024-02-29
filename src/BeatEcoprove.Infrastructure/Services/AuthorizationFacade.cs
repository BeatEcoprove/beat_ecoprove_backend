using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class AuthorizationFacade : IAuthorizationFacade
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;

    public AuthorizationFacade(
        IAuthRepository authRepository,
        IProfileRepository profileRepository)
    {
        _authRepository = authRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<Profile>> GetAuthProfileByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        var userEmail = Email.Create(email);

        if (userEmail.IsError)
        {
            return userEmail.Errors;
        }

        var auth = await _authRepository.GetAuthByEmail(userEmail.Value, cancellationToken);

        if (auth is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        var profile = await _profileRepository.GetProfileByAuthId(auth.Id, cancellationToken);

        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }

        return profile;
    }
}