using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.CreateGroup;

public record CreateGroupCommand
(
    Guid AuthId,
    Guid ProfileId,
    Stream AvatarPicture,
    string Name,
    string Description,
    bool IsPublic
) : IAuthorization, ICommand<ErrorOr<Group>>;