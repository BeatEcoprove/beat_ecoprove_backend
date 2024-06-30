using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetStoreById;

internal sealed class GetStoreByIdQueryHandler : IQueryHandler<GetStoreByIdQuery, ErrorOr<Store>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;

    public GetStoreByIdQueryHandler(IProfileManager profileManager, IStoreService storeService)
    {
        _profileManager = profileManager;
        _storeService = storeService;
    }

    public async Task<ErrorOr<Store>> Handle(GetStoreByIdQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeService.GetStoreAsync(storeId, profile.Value, cancellationToken);

        if (store.IsError)
        {
            return store.Errors;
        }
        
        return store.Value;
    }
}