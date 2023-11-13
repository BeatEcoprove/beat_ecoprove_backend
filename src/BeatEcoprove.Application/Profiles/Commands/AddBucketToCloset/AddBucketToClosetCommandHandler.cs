using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.AddBucketToCloset;

internal sealed class AddBucketToClosetCommandHandler : ICommandHandler<AddBucketToClosetCommand, ErrorOr<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProfileRepository _profileRepository;
    private readonly IBucketRepository _bucketRepository;

    public AddBucketToClosetCommandHandler(
        IUnitOfWork unitOfWork, 
        IProfileRepository profileRepository, 
        IBucketRepository bucketRepository)
    {
        _unitOfWork = unitOfWork;
        _profileRepository = profileRepository;
        _bucketRepository = bucketRepository;
    }

    public async Task<ErrorOr<string>> Handle(AddBucketToClosetCommand request, CancellationToken cancellationToken)
    {
        var profileId = ProfileId.Create(request.ProfileId);
        var convertToClothId = request.ClothIds.Select(ClothId.Create).ToList();

        var profile = await _profileRepository.GetByIdAsync(profileId, cancellationToken);

        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }
        
        var bucket = Bucket.Create(
            request.Name,
            convertToClothId
        );

        if (bucket.IsError)
        {
            return bucket.Errors;
        }
        
        profile.AddBucket(bucket.Value);
        
        await _bucketRepository.AddAsync(bucket.Value, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return bucket.Value.Name;
    }
}