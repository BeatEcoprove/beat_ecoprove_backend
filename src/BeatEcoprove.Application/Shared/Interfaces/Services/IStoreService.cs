using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IStoreService
{
    Task<List<Order>> GetAllStores(
        ProfileId Owner,
        GetAllStoreInput input,
        CancellationToken cancellationToken = default
    );
    
     Task<ErrorOr<Store>> GetStoreAsync(
            StoreId id,
            Profile profile,
            CancellationToken cancellationToken = default);
     
    Task<ErrorOr<Store>> CreateStoreAsync(
        Store store,
        Stream avatarPicture,
        CancellationToken cancellationToken = default);
}