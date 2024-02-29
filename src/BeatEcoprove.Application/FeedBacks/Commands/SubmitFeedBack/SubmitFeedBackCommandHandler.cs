using BeatEcoprove.Application.FeedBacks.Commands.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.FeedBacks.Commands.SubmitFeedBack;

internal sealed class SubmitFeedBackCommandHandler : ICommandHandler<SubmitFeedBackCommand, ErrorOr<FeedBackResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IFeedBackRepository _feedBackRepository;
    private readonly IUnitOfWork _unitOfWork;

    public SubmitFeedBackCommandHandler(
        IProfileManager profileManager,
        IFeedBackRepository feedBackRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _feedBackRepository = feedBackRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<FeedBackResult>> Handle(SubmitFeedBackCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var title = Title.Create(request.Title);

        if (title.IsError)
        {
            return title.Errors;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var feedBack = FeedBack.Create(
            profile.Value.Id,
            title.Value,
            request.Description);

        await _feedBackRepository.AddAsync(feedBack.Value, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return new FeedBackResult(
            feedBack.Value.Id,
            profile.Value,
            feedBack.Value.Title,
            feedBack.Value.Description
        );
    }
}