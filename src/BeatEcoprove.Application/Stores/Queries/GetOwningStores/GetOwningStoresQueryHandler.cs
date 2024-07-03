using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOwningStores;

internal sealed class GetOwningStoresQueryHandler : IQueryHandler<GetOwningStoresQuery, ErrorOr<List<Store>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;

    public GetOwningStoresQueryHandler(
        IProfileManager profileManager, 
        IStoreService storeService)
    {
        _profileManager = profileManager;
        _storeService = storeService;
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
        
        var stores = await _storeService.GetOwningStoreAsync(
            profile.Value,
            new GetOwningStoreInput(
                request.Search,
                request.Page,
                request.PageSize
            ),
            cancellationToken);

        if (stores.IsError)
        {
            return stores.Errors;
        }

        return stores;
    }
}