using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetProfile;

public record GetProfileQuery
(
    Guid AuthId,
    Guid ProfileId,
    string username
) : IQuery<ErrorOr<Profile>>, IAuthorization;