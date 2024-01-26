using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.InviteMember;

public record InviteMemberCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    Guid InviteeId
) : ICommand<ErrorOr<Group>>, IAuthorization;