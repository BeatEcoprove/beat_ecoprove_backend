using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.ElevatePermissionOnWorker;

internal sealed class ElevatePermissionOnWorkerHandler : ICommandHandler<ElevatePermissionOnWorkerCommand, ErrorOr<WorkerDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStoreRepository _storeRepository;

    public ElevatePermissionOnWorkerHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IUnitOfWork unitOfWork, 
        IStoreRepository storeRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _unitOfWork = unitOfWork;
        _storeRepository = storeRepository;
    }

    public async Task<ErrorOr<WorkerDao>> Handle(ElevatePermissionOnWorkerCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);
        var workerId = WorkerId.Create(request.WorkerId);
        var workerType = _storeService.GetWorkerType(request.Permission);

        if (workerType.IsError)
        {
            return workerType.Errors;
        }

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

        var worker = await _storeService.SwitchPermission(
            store.Value,
            profile.Value,
            new SwitchPermissionInput(
                workerId,
                workerType.Value
            ),
            cancellationToken
        );

        if (worker.IsError)
        {
            return worker.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var workerDao = await _storeRepository.GetWorkerDaoAsync(
            workerId,
            cancellationToken
        );

        if (workerDao is null)
        {
            return Errors.Worker.NotFound;
        }

        return workerDao;
    }
}