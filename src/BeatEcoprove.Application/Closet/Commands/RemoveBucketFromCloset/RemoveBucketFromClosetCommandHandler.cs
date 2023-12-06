using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RemoveBucketFromCloset;

internal sealed class RemoveBucketFromClosetCommandHandler : ICommandHandler<RemoveBucketFromClosetCommand, ErrorOr<BucketResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveBucketFromClosetCommandHandler(
        IProfileManager profileManager, 
        IClosetService closetService, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<BucketResult>> Handle(RemoveBucketFromClosetCommand request, CancellationToken cancellationToken)
    {
        var bucketId = BucketId.Create(request.BucketId);
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var bucket = await _closetService.RemoveBucketFromCloset(profile.Value, bucketId, cancellationToken);

        if (bucket.IsError)
        {
            return bucket.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return bucket;
    }
}