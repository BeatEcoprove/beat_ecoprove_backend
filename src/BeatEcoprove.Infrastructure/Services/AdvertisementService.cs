using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;

using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class AdvertisementService : IAdvertisementService
{
    private readonly IStoreRepository _storeRepository;
    private readonly IAdvertisementRepository _advertisementRepository;
    private readonly IFileStorageProvider _fileProvider;

    public AdvertisementService(
        IStoreRepository storeRepository, 
        IAdvertisementRepository advertisementRepository, 
        IFileStorageProvider fileProvider)
    {
        _storeRepository = storeRepository;
        _advertisementRepository = advertisementRepository;
        _fileProvider = fileProvider;
    }

    public async Task<ErrorOr<Advertisement>> GetAdvertAsync(
        AdvertisementId advertId, 
        Profile profile, 
        bool checkAuthorization = true,
        CancellationToken cancellationToken = default)
    {
        var advert = await _advertisementRepository.GetByIdAsync(advertId, cancellationToken);

        if (advert is null)
        {
            return Errors.Advertisement.NotFound;
        }
        
        if (!checkAuthorization)
        {
            return advert;
        }

        if (!await _advertisementRepository.HasProfileAccessToAdvert(advertId, profile.Id, cancellationToken))
        {
            return Errors.Advertisement.CannotPerformThis;
        }

        return advert;
    }

    public async Task<ErrorOr<Advertisement>> CreateAdd(
        Advertisement advertisement,
        Profile profile,
        Stream picture,
        CancellationToken cancellationToken = default)
    {
        if (advertisement.InitDate >= advertisement.EndDate)
        {
            return Errors.Advertisement.CannotPerformThis;
        }
        
        if (profile.Type.Equals(UserType.Consumer))
        {
            return Errors.Advertisement.CannotPerformThis;
        }

        if (profile.Type.Equals(UserType.Employee))
        {
            var result = await DoIfEmployee(profile, cancellationToken);

            if (result.IsError)
            {
                return result.Errors;
            }
        }

        var avatarUrl = 
            await _fileProvider
                .UploadFileAsync(
                    Buckets.AdvertisementBucket,
                    ((Guid)advertisement.Id).ToString(), 
                    picture,
                    cancellationToken);
                        
        advertisement.SetPictureUrl(avatarUrl);
        await _advertisementRepository.AddAsync(advertisement, cancellationToken);
        
        return advertisement;
    }

    private async Task<ErrorOr<Profile>> DoIfEmployee(Profile profile, CancellationToken cancellationToken)
    {
        var worker = await _storeRepository.GetWorkerByProfileAsync(profile.Id, cancellationToken);

        if (worker is null)
        {
            return Errors.Worker.NotFound;
        }

        if (worker.Role != WorkerType.Manager)
        {
            return Errors.Advertisement.CannotPerformThis;
        }

        return profile;
    }
}