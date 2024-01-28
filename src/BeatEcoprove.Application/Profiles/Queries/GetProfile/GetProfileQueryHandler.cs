using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetProfile;

internal sealed class GetProfileQueryHandler : IQueryHandler<GetProfileQuery, ErrorOr<Profile>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;

    public GetProfileQueryHandler(IProfileManager profileManager, IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<Profile>> Handle(GetProfileQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var username = UserName.Create(request.username);
        
        if (username.IsError)
        {
            return username.Errors;
        }
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);
        
        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var getProfile = await _profileRepository.GetByUserNameAsync(username.Value, cancellationToken);
        
        if (getProfile is null)
        {
            return Errors.Profile.NotFound;
        }

        return getProfile;
    }
}