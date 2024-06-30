using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class StoreService : IStoreService
{
    private readonly IStoreRepository _storeRepository;
    private readonly IFileStorageProvider _fileStorageProvider;
    
    public async Task<ErrorOr<Store>> CreateStoreAsync(Store store, Stream picture, CancellationToken cancellationToken)
    {
        if (!await _storeRepository.ExistsAnyStoreWithName(store.Name, cancellationToken))
        {
            return Errors.Store.RateNotAllowed;
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