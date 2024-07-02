using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AdvertisementAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetMyAdverts;

public record GetMyAdvertsQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    string? Search = null,
    int Page = 1,
    int PageSize = 10
) : IAuthorization, IQuery<ErrorOr<List<Advertisement>>>;