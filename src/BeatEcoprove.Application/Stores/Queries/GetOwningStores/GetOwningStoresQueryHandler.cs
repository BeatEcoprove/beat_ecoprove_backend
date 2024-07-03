using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOwningStores;

internal sealed class GetOwningStoresQueryHandler : IQueryHandler<GetOwningStoresQuery, ErrorOr<List<Store>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreRepository _storeRepository;

    public GetOwningStoresQueryHandler(
        IProfileManager profileManager, 
        IStoreRepository storeRepository)
    {
        _profileManager = profileManager;
        _storeRepository = storeRepository;
    }

    public async Task<ErrorOr<List<Store>>> Handle(GetOwningStoresQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var stores = await _storeRepository.GetOwningStoreAsync(
            profile.Value.Id,
            request.Search,
            request.Page,
            request.PageSize,
            cancellationToken);

        return stores;
    }
}