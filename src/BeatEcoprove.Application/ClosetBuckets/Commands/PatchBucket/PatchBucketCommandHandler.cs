using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.ClosetBuckets.Commands;

internal sealed class PatchBucketCommandHandler : ICommandHandler<PatchBucketCommand, ErrorOr<Bucket>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;
    private readonly IBucketRepository _bucketRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PatchBucketCommandHandler(
        IProfileManager profileManager,
        IProfileRepository profileRepository,
        IBucketRepository bucketRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
        _bucketRepository = bucketRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Bucket>> Handle(PatchBucketCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var bucketId = BucketId.Create(request.BucketId);

        if (string.IsNullOrWhiteSpace(request.Name))
        {
            return Errors.Bucket.NameCannotBeEmpty;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        if (!await _profileRepository.CanProfileAccessBucket(profile.Value.Id, bucketId, cancellationToken))
        {
            return Errors.Bucket.CannotAccessBucket;
        }

        if (await _bucketRepository.IsBucketNameAlreadyUsed(profile.Value.Id, bucketId, request.Name, cancellationToken))
        {
            return Errors.Bucket.BucketNameAlreadyUsed;
        }

        var bucket = await _bucketRepository.GetByIdAsync(bucketId, cancellationToken);

        if (bucket is null)
        {
            return Errors.Bucket.BucketDoesNotExists;
        }

        bucket.SetName(request.Name);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return bucket;
    }
}