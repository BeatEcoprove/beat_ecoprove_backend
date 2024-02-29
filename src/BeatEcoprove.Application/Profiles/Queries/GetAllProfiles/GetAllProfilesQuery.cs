using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetAllProfiles;

public record GetAllProfilesQuery
(
    Guid AuthId,
    Guid ProfileId,
    string? Search,
    int Page = 1,
    int PageSize = 10
) : IQuery<ErrorOr<List<Profile>>>, IAuthorization;