using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetBucketsCloth;

internal sealed class GetBucketsClothQueryHandler : IQueryHandler<GetBucketsClothQuery, ErrorOr<List<BucketResult>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IClothRepository _clothRepository;

    public GetBucketsClothQueryHandler(
        IProfileManager profileManager,
        IClosetService closetService,
        IClothRepository clothRepository)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _clothRepository = clothRepository;
    }

    public async Task<ErrorOr<List<BucketResult>>> Handle(GetBucketsClothQuery request, CancellationToken cancellationToken)
    {
        List<BucketResult> bucketResults = new();
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var clothId = ClothId.Create(request.ClothId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var buckets = await _clothRepository.GetBuckets(clothId, cancellationToken);

        foreach (var bucket in buckets)
        {
            var bucketResult = await _closetService.GetBucketResult(profile.Value, bucket, cancellationToken);

            if (bucketResult.IsError)
            {
                return bucketResult.Errors;
            }

            bucketResults.Add(bucketResult.Value);
        }

        return bucketResults;
    }
}