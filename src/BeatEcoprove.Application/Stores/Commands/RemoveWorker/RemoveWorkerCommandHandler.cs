using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.RemoveWorker;

internal sealed class RemoveWorkerCommandHandler : ICommandHandler<RemoveWorkerCommand, ErrorOr<WorkerDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveWorkerCommandHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IStoreRepository storeRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<WorkerDao>> Handle(RemoveWorkerCommand request, CancellationToken cancellationToken)
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

        var store = await _storeService.GetStoreAsync(
            storeId,
            profile.Value,
            cancellationToken);

        if (store.IsError)
        {
            return store.Errors;
        }
        
        var worker = await _storeService.RemoveWorkerAsync(
            store.Value,
            profile.Value,
            workerId,
            cancellationToken
        );

        if (worker.IsError)
        {
            return worker.Errors;
        }
        
        var workerDao = await _storeRepository.GetWorkerDaoAsync(workerId, cancellationToken);
        
        if (workerDao is null)
        {
            return Errors.Worker.NotFound;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return workerDao;
    }
}