using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;

using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetMyProfiles;

internal sealed class GetMyProfilesQueryHandler : IQueryHandler<GetMyProfilesQuery, ErrorOr<List<ProfileDao>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;

    public GetMyProfilesQueryHandler(
        IProfileManager profileManager,
        IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<List<ProfileDao>>> Handle(GetMyProfilesQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);

        var profile = await _profileManager.GetProfileAsync(authId, Guid.Empty, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var profileList = await _profileRepository.GetAllProfilesOfAuthIdAsync(authId, cancellationToken);

        return profileList;
    }
}