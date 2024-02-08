using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using System.Net.WebSockets;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public record Member(
    AuthId Id,
    WebSocket Socket
);