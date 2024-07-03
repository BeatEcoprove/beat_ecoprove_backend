using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetWorkerById;

internal sealed class GetWorkerByIdQueryHandler : IQueryHandler<GetWorkerByIdQuery, ErrorOr<WorkerDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;

    public GetWorkerByIdQueryHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IStoreRepository storeRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
    }

    public async Task<ErrorOr<WorkerDao>> Handle(GetWorkerByIdQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);
        var workerId = WorkerId.Create(request.WorkerId);

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

        var worker = store.Value.Workers
           .FirstOrDefault(worker => worker.Id == workerId);

        if (worker is null)
        { 
            return Errors.Worker.NotFound;
        }

        var workerDao = await _storeRepository.GetWorkerDaoAsync(worker.Id, cancellationToken);

        if (workerDao is null)
        {
            return Errors.Worker.NotFound;
        }

        return workerDao;
    }
}