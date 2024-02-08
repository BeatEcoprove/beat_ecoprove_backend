namespace BeatEcoprove.Infrastructure.WebSockets.Exceptions;

internal class WebSocketEventHandlerException : Exception
{
    public WebSocketEventHandlerException(string message)
        : base(message) { }
}
