using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetStoreById;

public record GetStoreByIdQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId
) : IAuthorization, IQuery<ErrorOr<Store>>;