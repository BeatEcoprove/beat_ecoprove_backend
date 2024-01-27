namespace BeatEcoprove.Infrastructure.WebSockets.Handlers;

public abstract class WebSocketHandler
{
    protected readonly ConnectionManager ConnectionManager;
    
    protected WebSocketHandler(ConnectionManager connectionManager)
    {
        this.ConnectionManager = connectionManager;
    }
    
    public abstract Task Handle(WebSocketMessage message, CancellationToken cancellationToken = default);
}