using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetStoreRatings;

public record GetStoreRatingsQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    int Page = 1,
    int PageSize = 10
) : IAuthorization, IQuery<ErrorOr<List<RatingDao>>>;