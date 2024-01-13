using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetMyProfiles;

// TODO: Add pagination??
public record GetMyProfilesQuery
(
    Guid AuthId
) : IQuery<ErrorOr<List<ProfileDao>>>;