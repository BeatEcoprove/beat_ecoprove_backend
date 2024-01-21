using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.KickMember;

public record KickMemberCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    Guid MemberId
) : ICommand<ErrorOr<Group>>, IAuthorization;