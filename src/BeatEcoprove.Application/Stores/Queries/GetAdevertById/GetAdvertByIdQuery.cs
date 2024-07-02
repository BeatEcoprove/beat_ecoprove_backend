using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AdvertisementAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetAdevertById;

public record GetAdvertByIdQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid AdvertisementId,
    bool CheckAuthorization = true
) : IAuthorization, IQuery<ErrorOr<Advertisement>>;