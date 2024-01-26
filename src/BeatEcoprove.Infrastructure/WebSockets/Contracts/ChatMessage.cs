namespace BeatEcoprove.Infrastructure.WebSockets.Contracts;

public record ChatMessage
(
    string GroupId,
    string SenderId,
    string Message
);