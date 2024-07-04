using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Application.Providers.Queries.GetProviderById;

public record GetProviderByIdQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid ProviderId
) : IAuthorization, IQuery<ErrorOr<ProviderDao>>;