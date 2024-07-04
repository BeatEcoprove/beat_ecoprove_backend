using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderStoreById;

internal sealed class GetProviderStoreByIdQueryHandler : IQueryHandler<GetProviderStoreByIdQuery, ErrorOr<Store>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IProfileRepository _profileRepository;

    public GetProviderStoreByIdQueryHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<Store>> Handle(GetProviderStoreByIdQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var providerId = ProfileId.Create(request.ProviderId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var provider = await _profileRepository.GetByIdAsync(providerId, cancellationToken);

        if (provider is null)
        {
            return Errors.Provider.NotFound;
        }

        var store = await _storeService.GetStoreAsync(
            storeId,
            provider,
            cancellationToken);

        if (store.IsError)
        {
            return store.Errors;
        }

        return store;
    }
}