using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOwningStores;

public record GetOwningStoresQuery
(
    Guid AuthId,
    Guid ProfileId,
    string? Search = null,
    int Page = 1,
    int PageSize = 10
) : IAuthorization, IQuery<ErrorOr<List<Store>>>;