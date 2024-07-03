using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.PostRating;

internal sealed class PostRatingCommandHandler : ICommandHandler<PostRatingCommand, ErrorOr<RatingDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreRepository _storeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PostRatingCommandHandler(
        IProfileManager profileManager, 
        IStoreRepository storeRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _storeRepository = storeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<RatingDao>> Handle(PostRatingCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeRepository.GetByIdAsync(storeId, cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        var rating = store.AddRating(
            profile.Value,
            request.Rating
        );

        if (rating.IsError)
        {
            return rating.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return new RatingDao(
            store.Id,
            rating.Value.Rate,
            profile.Value
        );
    }
}