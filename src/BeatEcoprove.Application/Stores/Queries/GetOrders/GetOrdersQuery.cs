using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOrders;

public record GetOrdersQuery
(
    Guid AuthId,
    Guid ProfileId,
    string StoreIds,
    string? Search = null,
    string? Services = null,
    string? Color = null,
    string? Brand = null,
    bool? IsDone = null,
    int Page = 0,
    int PageSize = 10
) : IAuthorization, IQuery<ErrorOr<List<OrderDAO>>>;