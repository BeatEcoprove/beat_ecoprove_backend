using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RemoveClothFromBucket;

internal sealed class RemoveClothFromBucketCommandHandler : ICommandHandler<RemoveClothFromBucketCommand, ErrorOr<BucketResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IBucketRepository _bucketRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveClothFromBucketCommandHandler(
        IProfileManager profileManager,
        IClosetService closetService,
        IBucketRepository bucketRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _bucketRepository = bucketRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<BucketResult>> Handle(RemoveClothFromBucketCommand request, CancellationToken cancellationToken)
    {
        BucketId bucketId = BucketId.Create(request.BucketId);

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

        var shouldRemoveClothFromBucket = await _closetService.RemoveClothFromBucket(
            profile.Value,
            bucket,
            ToClothIdList(request.ClothToRemove),
            cancellationToken);

        if (shouldRemoveClothFromBucket.IsError)
        {
            return shouldRemoveClothFromBucket.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return await _closetService.GetBucketResult(profile.Value, bucket, cancellationToken);
    }

    private static List<ClothId> ToClothIdList(List<Guid> clothIds)
    {
        return clothIds.Select(ClothId.Create).ToList();
    }
}