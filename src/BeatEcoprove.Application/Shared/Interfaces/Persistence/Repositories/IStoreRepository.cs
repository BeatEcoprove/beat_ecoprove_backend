using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IStoreRepository : IRepository<Store, StoreId>
{
    public Task<bool> ExistsAnyStoreWithName(string name, CancellationToken cancellationToken = default);
    public Task<bool> HasAccessToStore(StoreId id, Profile manager, CancellationToken cancellationToken = default);
    Task<List<Order>> GetAllStoresAsync(
        Guid owner, 
        string? search, 
        List<Guid>? services = null, 
        List<Guid>? colorValue = null, 
        List<Guid>? brandValue = null,
        string? orderValue = null, 
        int pageSize = 10, 
        int page = 1,
        CancellationToken cancellationToken = default
    );
}