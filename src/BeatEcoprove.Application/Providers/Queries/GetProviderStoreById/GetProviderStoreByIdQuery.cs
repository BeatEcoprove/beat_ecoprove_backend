using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderStoreById;

public record GetProviderStoreByIdQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid ProviderId,
    Guid StoreId
) : IAuthorization, IQuery<ErrorOr<Store>>;