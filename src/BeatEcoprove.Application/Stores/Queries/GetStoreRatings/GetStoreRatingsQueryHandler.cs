using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetStoreRatings;

internal sealed class GetStoreRatingsQueryHandler : IQueryHandler<GetStoreRatingsQuery, ErrorOr<List<RatingDao>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreRepository _storeRepository;

    public GetStoreRatingsQueryHandler(
        IProfileManager profileManager, 
        IStoreRepository storeRepository)
    {
        _profileManager = profileManager;
        _storeRepository = storeRepository;
    }

    public async Task<ErrorOr<List<RatingDao>>> Handle(GetStoreRatingsQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeRepository.GetByIdAsync(storeId, cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        var ratings = await _storeRepository.GetRatingsFromStore(storeId, cancellationToken);
        return ratings;
    }
}