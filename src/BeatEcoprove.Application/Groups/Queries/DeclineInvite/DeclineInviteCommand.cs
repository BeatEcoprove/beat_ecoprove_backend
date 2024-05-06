using ErrorOr;

using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;

namespace BeatEcoprove.Application.Groups.Queries.DeclineInvite;

public record DeclineInviteCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    int Code
) : ICommand<ErrorOr<Group>>, IAuthorization;
