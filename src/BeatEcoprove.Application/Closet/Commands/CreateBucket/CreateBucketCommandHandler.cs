using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateBucket;

internal sealed class CreateBucketCommandHandler : ICommandHandler<CreateBucketCommand, ErrorOr<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBucketRepository _bucketRepository;
    private readonly IProfileManager _profileManager;

    public CreateBucketCommandHandler(
        IUnitOfWork unitOfWork, 
        IBucketRepository bucketRepository, 
        IProfileManager profileManager)
    {
        _unitOfWork = unitOfWork;
        _bucketRepository = bucketRepository;
        _profileManager = profileManager;
    }

    public async Task<ErrorOr<string>> Handle(CreateBucketCommand request, CancellationToken cancellationToken)
    {
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var convertToClothId = request.ClothIds.Select(ClothId.Create).ToList();

        var bucket = Bucket.Create(
            request.Name,
            convertToClothId
        );

        if (bucket.IsError)
        {
            return bucket.Errors;
        }
        
        profile.Value.AddBucket(bucket.Value);
        
        await _bucketRepository.AddAsync(bucket.Value, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return bucket.Value.Name;
    }
}