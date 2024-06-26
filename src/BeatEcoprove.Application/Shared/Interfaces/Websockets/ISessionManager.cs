﻿using System.Net.WebSockets;

using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public interface ISessionManager : IConnectionManager<ProfileId, WebSocket>
{
    bool IsUserAuthenticated(ProfileId userId);
    Task CloseAsync(ProfileId userId, WebSocketCloseStatus status, string reason, CancellationToken cancellation = default);
    WebSocket Delete(ProfileId userId);
}