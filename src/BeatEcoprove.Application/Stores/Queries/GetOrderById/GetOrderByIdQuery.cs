using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOrderById;

public record GetOrderByIdQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid OrderId,
    Guid StoreId
) : IAuthorization, IQuery<ErrorOr<OrderDAO>>;