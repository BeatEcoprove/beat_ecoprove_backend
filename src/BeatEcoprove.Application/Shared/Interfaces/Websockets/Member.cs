using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using System.Net.WebSockets;

namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public record Member(
    ProfileId Id,
    WebSocket Socket
);