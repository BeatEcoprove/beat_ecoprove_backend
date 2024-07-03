using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetWorkerById;

public record GetWorkerByIdQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    Guid WorkerId
) : IAuthorization, IQuery<ErrorOr<WorkerDao>>;