using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

using ErrorOr;

using Mapster;

namespace BeatEcoprove.Application.Closet.Queries.GetCurrentOutfit;

internal sealed class GetCurrentOutfitQueryHandler : IQueryHandler<GetCurrentOutfitQuery, ErrorOr<BucketResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IActivityRepository _activityRepository;

    public GetCurrentOutfitQueryHandler(
        IProfileManager profileManager,
        IActivityRepository activityRepository)
    {
        _profileManager = profileManager;
        _activityRepository = activityRepository;
    }

    public async Task<ErrorOr<BucketResult>> Handle(GetCurrentOutfitQuery request, CancellationToken cancellationToken)
    {
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var outfit = await _activityRepository.GetCurrentOutfitAsync(profile.Value.Id, cancellationToken);
        var cloths = outfit.Select(cloth => cloth.Adapt<ClothResult>()).ToList();

        var outfitBucket = Bucket.Create("Outfit");

        if (outfitBucket.IsError)
        {
            return outfitBucket.Errors;
        }

        outfitBucket.Value.AddCloths(cloths.Select(cloth => ClothId.Create(cloth.Id)).ToList());

        // Creates the outfit by default
        return new BucketResult(
            outfitBucket.Value,
            cloths
            );
    }
}