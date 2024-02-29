using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetAllProfiles;

internal sealed class GetAllProfilesQueryHandler : IQueryHandler<GetAllProfilesQuery, ErrorOr<List<Profile>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;

    public GetAllProfilesQueryHandler(IProfileManager profileManager, IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<List<Profile>>> Handle(GetAllProfilesQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var profiles = await _profileRepository.GetAllProfilesAsync(
            request.Search?.ToLower(),
            request.PageSize,
            request.Page,
            cancellationToken
        );

        return profiles;
    }
}