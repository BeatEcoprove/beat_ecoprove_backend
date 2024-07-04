using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.RemoveWorker;

public record RemoveWorkerCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    Guid WorkerId
) : IAuthorization, ICommand<ErrorOr<WorkerDao>>;