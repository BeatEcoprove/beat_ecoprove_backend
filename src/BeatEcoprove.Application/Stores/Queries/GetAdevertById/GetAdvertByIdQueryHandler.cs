using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetAdevertById;

internal sealed class GetAdvertByIdQueryHandler : IQueryHandler<GetAdvertByIdQuery, ErrorOr<Advertisement>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAdvertisementService _advertisementService;
    private readonly IAdvertisementRepository _advertisementRepository;

    public GetAdvertByIdQueryHandler(
        IProfileManager profileManager, 
        IAdvertisementService advertisementService, 
        IAdvertisementRepository advertisementRepository)
    {
        _profileManager = profileManager;
        _advertisementService = advertisementService;
        _advertisementRepository = advertisementRepository;
    }

    public async Task<ErrorOr<Advertisement>> Handle(GetAdvertByIdQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var advertId = AdvertisementId.Create(request.AdvertisementId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var advert = await _advertisementService.GetAdvertAsync(
            advertId,
            profile.Value,
            request.CheckAuthorization,
            cancellationToken
        );

        if (advert.IsError)
        {
            return advert.Errors;
        }

        return advert;
    }
}