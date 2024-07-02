using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IAdvertisementRepository : IRepository<Advertisement, AdvertisementId>
{
    Task<List<Advertisement>> GetAllAddsAsync(
        List<ProfileId>? haveAccess = null,
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);

    Task<bool> HasProfileAccessToAdvert(
        AdvertisementId advertId, 
        ProfileId profile, 
        CancellationToken cancellationToken = default);
}