using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using ErrorOr;
using Mapster;

namespace BeatEcoprove.Application.Closet.Commands.CreateBucket;

internal sealed class CreateBucketCommandHandler : ICommandHandler<CreateBucketCommand, ErrorOr<BucketResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IBucketRepository _bucketRepository;
    private readonly IClosetService _closetService;
    private readonly IUnitOfWork _unitOfWork;

    public CreateBucketCommandHandler(
        IProfileManager profileManager,
        IBucketRepository bucketRepository,
        IClosetService closetService, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _bucketRepository = bucketRepository;
        _closetService = closetService;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<BucketResult>> Handle(CreateBucketCommand request, CancellationToken cancellationToken)
    {
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var bucket = Bucket.Create(
            request.Name.Capitalize()
        );

        if (bucket.IsError)
        {
            return bucket.Errors;
        }

        var shouldAddBucketToCloset = await _closetService.AddBucketToCloset(
            profile.Value, 
            bucket.Value, 
            ToClothIdList(request), 
            cancellationToken);
        
        if (shouldAddBucketToCloset.IsError)
        {
            return shouldAddBucketToCloset.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        var cloths = await
            _bucketRepository.GetClothsAsync(bucket.Value.Id, cancellationToken);
        
        return new BucketResult(
            bucket.Value,
            cloths.Adapt<List<ClothResult>>());
    }

    private static List<ClothId> ToClothIdList(CreateBucketCommand request)
    {
        return request.ClothIds.Select(ClothId.Create).ToList();
    }
}