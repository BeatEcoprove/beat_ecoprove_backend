using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderStores;

internal sealed class GetProviderStoresQueryHandler : IQueryHandler<GetProviderStoresQuery, ErrorOr<List<Store>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IProfileRepository _profileRepository;

    public GetProviderStoresQueryHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<List<Store>>> Handle(GetProviderStoresQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var providerId = ProfileId.Create(request.ProviderId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var serviceProvider = await _profileRepository.GetByIdAsync(
            providerId,
            cancellationToken);

        if (serviceProvider is null)
        {
            return Errors.Provider.NotFound;
        }

        var stores = await _storeService.GetOwningStoreAsync(
            serviceProvider,
            new GetOwningStoreInput(
                request.Search,
                request.Page,
                request.PageSize
            ),
            cancellationToken
        );

        if (stores.IsError)
        {
            return stores.Errors;
        }

        return stores;
    }
}