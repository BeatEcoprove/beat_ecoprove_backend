using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetHomeAdds;

internal sealed class GetHomeAddsQueryHandler : IQueryHandler<GetHomeAddsQuery, ErrorOr<List<Advertisement>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAdvertisementRepository _advertisementRepository;

    public GetHomeAddsQueryHandler(
        IProfileManager profileManager, 
        IAdvertisementRepository advertisementRepository)
    {
        _profileManager = profileManager;
        _advertisementRepository = advertisementRepository;
    }

    public async Task<ErrorOr<List<Advertisement>>> Handle(GetHomeAddsQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var adds = await _advertisementRepository.GetAllAddsAsync(
            search: request.Search,
            page: request.Page,
            pageSize: request.PageSize,
            cancellationToken:  cancellationToken
        );

        return adds;
    }
}