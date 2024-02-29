namespace BeatEcoprove.Infrastructure.WebSockets.Exceptions;

internal class WebSocketEventException : Exception
{
    private const string EventNotValid = "Event is not valid";

    public WebSocketEventException()
        : base(EventNotValid) { }
}