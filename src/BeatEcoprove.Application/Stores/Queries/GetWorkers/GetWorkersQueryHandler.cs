using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetWorkers;

internal sealed class GetWorkersQueryHandler : IQueryHandler<GetWorkersQuery, ErrorOr<List<WorkerDao>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;

    public GetWorkersQueryHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IStoreRepository storeRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
    }

    public async Task<ErrorOr<List<WorkerDao>>> Handle(GetWorkersQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeService.GetStoreAsync(storeId, profile.Value, cancellationToken);

        if (store.IsError)
        {
            return store.Errors;
        }

        var workers = await _storeRepository.GetWorkerDaosAsync(
            store.Value.Id,
            request.Search,
            request.Page,
            request.PageSize,
            cancellationToken);

        return workers;
    }
}