using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateBucket;

internal sealed class CreateBucketCommandHandler : ICommandHandler<CreateBucketCommand, ErrorOr<BucketResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IBucketRepository _bucketRepository;
    private readonly IClosetService _closetService;

    public CreateBucketCommandHandler(
        IProfileManager profileManager,
        IBucketRepository bucketRepository,
        IClosetService closetService)
    {
        _profileManager = profileManager;
        _bucketRepository = bucketRepository;
        _closetService = closetService;
    }

    public async Task<ErrorOr<BucketResult>> Handle(CreateBucketCommand request, CancellationToken cancellationToken)
    {
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var convertToClothId = request.ClothIds.Select(ClothId.Create).ToList();
        
        if (!await _bucketRepository.CanAddClothsAsync(null, cancellationToken))
        {
            return Errors.Bucket.CanAddClothToBucket;
        }

        var bucket = Bucket.Create(
            request.Name,
            convertToClothId
        );

        if (bucket.IsError)
        {
            return bucket.Errors;
        }

        var bucketResult = await _closetService.AddBucketToCloset(profile.Value, bucket.Value, cancellationToken);
        
        return bucketResult;
    }
}