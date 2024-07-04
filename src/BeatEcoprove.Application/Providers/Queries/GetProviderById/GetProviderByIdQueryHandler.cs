using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderById;

internal sealed class GetProviderByIdQueryHandler : IQueryHandler<GetProviderByIdQuery, ErrorOr<ProviderDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProviderService _providerService;

    public GetProviderByIdQueryHandler(
        IProfileManager profileManager, 
        IProviderService providerService)
    {
        _profileManager = profileManager;
        _providerService = providerService;
    }

    public async Task<ErrorOr<ProviderDao>> Handle(GetProviderByIdQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var providerId = ProfileId.Create(request.ProviderId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var organization = await _providerService.GetProviderByIdAsync(
            providerId,
            cancellationToken);

        if (organization.IsError)
        {
            return organization.Errors;
        }

        return organization;
    }
}