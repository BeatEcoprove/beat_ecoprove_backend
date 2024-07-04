using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetAllStandardProviders;

internal sealed class GetAllStandardProvidersQueryHandler : IQueryHandler<GetAllStandardProvidersQuery, ErrorOr<List<Organization>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProviderService _providerService;

    public GetAllStandardProvidersQueryHandler(
        IProfileManager profileManager,
        IProviderService providerService)
    {
        _profileManager = profileManager;
        _providerService = providerService;
    }

    public async Task<ErrorOr<List<Organization>>> Handle(GetAllStandardProvidersQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var providers = await _providerService.GetAllProvidersAsync(
            new GetAllProviderInput(
                request.Search,
                request.Page,
                request.PageSize
            ),
            cancellationToken);

        if (providers.IsError)
        {
            return providers.Errors;
        }

        return providers;
    }
}