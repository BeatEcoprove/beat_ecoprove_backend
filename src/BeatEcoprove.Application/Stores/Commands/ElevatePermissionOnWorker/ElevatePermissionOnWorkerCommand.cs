using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.ElevatePermissionOnWorker;

public record ElevatePermissionOnWorkerCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    Guid WorkerId,
    string Permission
) : IAuthorization, ICommand<ErrorOr<WorkerDao>>;