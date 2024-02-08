using BeatEcoprove.Application.Shared;

namespace BeatEcoprove.Application.Groups.Queries.ConnectToGroup;

public record ConnectToGroupQuery
(
    Guid GroupId
) : IQuery<string>;
