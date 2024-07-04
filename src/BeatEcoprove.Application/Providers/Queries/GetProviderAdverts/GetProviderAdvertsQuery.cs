using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AdvertisementAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderAdverts;

public record GetProviderAdvertsQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid ProviderId,
    string? Search = null,
    int Page = 1,
    int PageSize = 10
) : IAuthorization, IQuery<ErrorOr<List<Advertisement>>>;