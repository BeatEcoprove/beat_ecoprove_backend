using System.Net.WebSockets;

using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public record Member(
    ProfileId Id,
    WebSocket Socket
);