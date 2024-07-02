using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IAdvertisementService
{
    Task<ErrorOr<Advertisement>> GetAdvertAsync(
        AdvertisementId advertId,
        Profile profile,
        bool checkAuthorization = true,
        CancellationToken cancellationToken = default);
    
    Task<ErrorOr<List<Advertisement>>> GetMyAdvertsAsync(
        StoreId storeId,
        Profile profile, 
        string? search = null, 
        int page = 1, 
        int pageSize = 10,
        CancellationToken cancellationToken = default);    
    
    Task<ErrorOr<Advertisement>> CreateAdd(
        Advertisement advertisement,
        Profile profile,
        Stream picture,
        CancellationToken cancellationToken = default);

    Task<ErrorOr<Advertisement>> DeleteAsync(
        Advertisement advertisement,
        Profile profile,
        CancellationToken cancellationToken = default);
}