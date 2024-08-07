using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IStoreService
{
    Task GivePointsTo(
        Store store,
        Profile owner,
        int sustainablePoints,
        CancellationToken cancellationToken = default);
    Task<List<Order>> GetAllStoresAsync(
        ProfileId owner,
        GetAllStoreInput input,
        CancellationToken cancellationToken = default
    );
    Task<ErrorOr<List<Store>>> GetOwningStoreAsync(
        Profile profile,
        GetOwningStoreInput input,
        CancellationToken cancellationToken = default);
    
     Task<ErrorOr<Store>> GetStoreAsync(
            StoreId id,
            Profile profile,
            CancellationToken cancellationToken = default);
    Task<ErrorOr<Store>> CreateStoreAsync(
        Store store,
        Profile profile,
        Stream avatarPicture,
        CancellationToken cancellationToken = default);
    Task<ErrorOr<Store>> DeleteStoreAsync(
        Store store,
        Profile profile,
        CancellationToken cancellationToken = default);
    Task<ErrorOr<Order>> RegisterOrderAsync(
        Store store, 
        ProfileId owner, 
        ClothId clothId,
        CancellationToken cancellationToken = default);
    Task<ErrorOr<Order>> CompleteOrderAsync(
        Store store, 
        OrderId order, 
        ProfileId owner,
        CancellationToken cancellationToken = default);
    Task<ErrorOr<(Worker, Password)>> RegisterWorkerAsync(
        Store store,
        Profile profile,
        AddWorkerInput input,
        CancellationToken cancellationToken = default);
    Task<ErrorOr<Worker>> RemoveWorkerAsync(
        Store store,
        Profile profile,
        WorkerId worker,
        CancellationToken cancellationToken = default);
    Task<ErrorOr<Worker>> SwitchPermission(
        Store store,
        Profile profile,
        SwitchPermissionInput input,
        CancellationToken cancellationToken = default);
    ErrorOr<WorkerType> GetWorkerType(string permission);
}