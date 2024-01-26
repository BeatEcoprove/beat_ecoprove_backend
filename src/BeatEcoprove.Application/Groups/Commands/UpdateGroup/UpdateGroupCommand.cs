using ErrorOr;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;

namespace BeatEcoprove.Application.Groups.Commands.UpdateGroup;

public record UpdateGroupCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    Guid MemberId,
    string? Name,
    string? Description,
    bool? IsPublic,
    Stream PictureStream
) : ICommand<ErrorOr<Group>>, IAuthorization;