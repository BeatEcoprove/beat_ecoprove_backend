using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetAllStores;

public record GetAllStoresQuery
(
    Guid AuthId,
    Guid ProfileId,
    string? Search,
    string? Services,
    string? Color,
    string? Brand,
    string? OrderBy,
    int Page = 1,
    int PageSize = 10) : IAuthorization, IQuery<ErrorOr<List<Order>>>;