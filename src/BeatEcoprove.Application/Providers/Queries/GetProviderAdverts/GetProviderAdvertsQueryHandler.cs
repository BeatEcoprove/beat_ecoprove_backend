using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderAdverts;

internal sealed class GetProviderAdvertsQueryHandler : IQueryHandler<GetProviderAdvertsQuery, ErrorOr<List<Advertisement>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAdvertisementRepository _advertisementRepository;
    private readonly IProfileRepository _profileRepository;

    public GetProviderAdvertsQueryHandler(
        IProfileManager profileManager, 
        IAdvertisementRepository advertisementRepository,
        IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _advertisementRepository = advertisementRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<List<Advertisement>>> Handle(GetProviderAdvertsQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var providerId = ProfileId.Create(request.ProviderId);

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

        var adverts = await _advertisementRepository.GetAllAdvertsFromOrganization(
            provider.Id,
            request.Search,
            request.Page,
            request.PageSize,
            cancellationToken);

        return adverts;
    }
}