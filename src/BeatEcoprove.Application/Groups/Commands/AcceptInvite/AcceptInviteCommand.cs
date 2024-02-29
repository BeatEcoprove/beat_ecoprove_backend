using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.AcceptInvite;

public record AcceptInviteCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    int Code
) : ICommand<ErrorOr<Group>>, IAuthorization;