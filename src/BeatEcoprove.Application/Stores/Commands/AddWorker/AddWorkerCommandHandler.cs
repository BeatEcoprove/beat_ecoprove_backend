using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.AddWorker;

internal sealed class AddWorkerCommandHandler : ICommandHandler<AddWorkerCommand, ErrorOr<WorkerDao>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;
    private readonly IMailSender _mailSender;
    private readonly IUnitOfWork _unitOfWork;

    public AddWorkerCommandHandler(IProfileManager profileManager, IStoreService storeService,
        IStoreRepository storeRepository, IMailSender mailSender, IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
        _mailSender = mailSender;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<WorkerDao>> Handle(AddWorkerCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);

        var workerType = _storeService.GetWorkerType(request.Permission);

        if (workerType.IsError)
        {
            return workerType.Errors;
        }

        var email = Email.Create(request.Email);

        if (email.IsError)
        {
            return email.Errors;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeRepository.GetByIdAsync(storeId, cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        var result = await _storeService.RegisterWorkerAsync(
            store,
            profile.Value,
            new AddWorkerInput(
                request.Name,
                email.Value,
                workerType.Value
            ),
            cancellationToken
        );

        if (result.IsError)
        {
            return result.Errors;
        }

        (Worker worker, Password password) = result.Value;

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var workerDao = await _storeRepository.GetWorkerDaoAsync(worker.Id, cancellationToken);

        if (workerDao is null)
        {
            return Errors.Worker.NotAllowedName;
        }

        await _mailSender.SendMailAsync(
            new Mail(
                email.Value,
                "Chave de accesso do empregado",
                $"Chave de Accesso: {password.Value}"
            ),
            cancellationToken
        );

        return workerDao;
    }
}