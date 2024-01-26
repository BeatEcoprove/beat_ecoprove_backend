using ErrorOr;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;

namespace BeatEcoprove.Application.Groups.Commands.DeleteGroup;

public record DeleteGroupCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId
) : ICommand<ErrorOr<Group>>, IAuthorization;