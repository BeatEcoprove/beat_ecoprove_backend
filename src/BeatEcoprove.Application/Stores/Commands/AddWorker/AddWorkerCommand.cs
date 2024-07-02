using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.AddWorker;

public record AddWorkerCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    string Name,
    string Email,
    string Permission
) : IAuthorization, ICommand<ErrorOr<WorkerDao>>;