using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.RemoveAdvert;

internal sealed class RemoveAdvertCommandHandler : ICommandHandler<RemoveAdvertCommand, ErrorOr<Advertisement>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAdvertisementService _advertisementService;
    private readonly IAdvertisementRepository _advertisementRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveAdvertCommandHandler(
        IProfileManager profileManager, 
        IAdvertisementService advertisementService,
        IAdvertisementRepository advertisementRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _advertisementService = advertisementService;
        _advertisementRepository = advertisementRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Advertisement>> Handle(RemoveAdvertCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var advertId = AdvertisementId.Create(request.AdvertId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var advert = await _advertisementRepository.GetByIdAsync(advertId, cancellationToken);

        if (advert is null)
        {
            return Errors.Advertisement.NotFound;
        }

        var deleteResult = await _advertisementService.DeleteAsync(
            advert,
            profile.Value,
            cancellationToken);

        if (deleteResult.IsError)
        {
            return deleteResult.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return advert;
    }
}