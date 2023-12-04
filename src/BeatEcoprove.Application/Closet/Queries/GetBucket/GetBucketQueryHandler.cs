using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetBucket;

internal sealed class GetBucketQueryHandler : IQueryHandler<GetBucketQuery, ErrorOr<BucketResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IBucketRepository _bucketRepository;
    private readonly IProfileRepository _profileRepository;
    
    public GetBucketQueryHandler(
        IProfileManager profileManager, 
        IClosetService closetService, 
        IBucketRepository bucketRepository, 
        IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _bucketRepository = bucketRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<BucketResult>> Handle(GetBucketQuery request, CancellationToken cancellationToken)
    {
        var bucketId = BucketId.Create(request.BucketId);
        
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var bucket = await _bucketRepository.GetByIdAsync(bucketId, cancellationToken);

        if (bucket is null)
        {
            return Errors.Bucket.BucketDoesNotExists;
        }
        
        if (!await _profileRepository.CanProfileAccessBucket(profile.Value.Id, bucket.Id, cancellationToken))
        {
            return Errors.Bucket.CannotAccessBucket;
        }

        return await _closetService.GetBucketResult(bucket, cancellationToken);
    }
}