using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class StoreService : IStoreService
{
    private readonly IStoreRepository _storeRepository;
    private readonly IFileStorageProvider _fileStorageProvider;

    public StoreService(IStoreRepository storeRepository, IFileStorageProvider fileStorageProvider)
    {
        _storeRepository = storeRepository;
        _fileStorageProvider = fileStorageProvider;
    }

    public async Task<ErrorOr<Store>> GetStoreAsync(StoreId id, Profile profile, CancellationToken cancellationToken = default)
    {
        if (!await _storeRepository.HasAccessToStore(id, profile, cancellationToken))
        {
            return Errors.Store.DontHaveAccessToStore;
        }

        var store = await _storeRepository.GetByIdAsync(id, cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        return store;
    }

    public async Task<ErrorOr<Store>> CreateStoreAsync(Store store, Stream picture, CancellationToken cancellationToken)
    {
        if (await _storeRepository.ExistsAnyStoreWithName(store.Name, cancellationToken))
        {
            return Errors.Store.StoreAlreadyExistsName;
        }
        
        var avatarUrl = 
             await _fileStorageProvider
                .UploadFileAsync(
                    Buckets.ProfileBucket,
                    ((Guid)store.Id).ToString(),
                    picture,
                    cancellationToken);
                
        store.SetPictureUrl(avatarUrl);

        await _storeRepository.AddAsync(store, cancellationToken);
        return store;
    }
}