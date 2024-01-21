using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.PromoteMember;

public record PromoteMemberCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    Guid MemberId,
    string Role
) : ICommand<ErrorOr<Group>>, IAuthorization;