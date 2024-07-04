using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IAdvertisementRepository : IRepository<Advertisement, AdvertisementId>
{
    Task<List<Advertisement>> GetAllHomeAdds(
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
    Task<List<Advertisement>> GetAllAddsAsync(
        ProfileId profile,
        bool isEmployee = false,
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
    Task<List<Advertisement>> GetAllAdvertsFromOrganization(
        ProfileId providerId,
        string? search = null,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default); 
    Task<bool> HasProfileAccessToAdvert(
        AdvertisementId advertId, 
        ProfileId profile, 
        bool isEmployee = false,
        CancellationToken cancellationToken = default);
    Task RemoveAsync(AdvertisementId id, CancellationToken cancellationToken = default);
}