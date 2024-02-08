using BeatEcoprove.Application.Shared;
using ErrorOr;
using System.Net.WebSockets;

namespace BeatEcoprove.Application.Groups.Queries.ConnectToGroup;

public record ConnectToGroupQuery
(
    Guid GroupId,
    Guid UserId,
    WebSocket UserSocket
) : IQuery<ErrorOr<bool>>;
