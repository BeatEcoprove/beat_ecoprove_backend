using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetMyAdverts;

internal sealed class GetMyAdvertsQueryHandler : IQueryHandler<GetMyAdvertsQuery, ErrorOr<List<Advertisement>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAdvertisementService _advertisementService;

    public GetMyAdvertsQueryHandler(
        IProfileManager profileManager, 
        IAdvertisementService advertisementService)
    {
        _profileManager = profileManager;
        _advertisementService = advertisementService;
    }

    public async Task<ErrorOr<List<Advertisement>>> Handle(GetMyAdvertsQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var adverts = await _advertisementService.GetMyAdvertsAsync(
            storeId,
            profile.Value,
            request.Search,
            request.Page,
            request.PageSize,
            cancellationToken
        );

        if (adverts.IsError)
        {
            return adverts.Errors;
        }

        return adverts;
    }
}