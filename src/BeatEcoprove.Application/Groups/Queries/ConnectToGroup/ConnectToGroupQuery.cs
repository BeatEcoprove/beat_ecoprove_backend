using System.Net.WebSockets;

using BeatEcoprove.Application.Shared;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.ConnectToGroup;

public record ConnectToGroupQuery
(
    Guid GroupId,
    Guid UserId,
    WebSocket UserSocket
) : IQuery<ErrorOr<bool>>;