using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Application.Shared.Notifications;
using BeatEcoprove.Domain.Documents;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.WebSockets.Events;
using BeatEcoprove.Infrastructure.WebSockets.Exceptions;
using MediatR;
using MongoDB.Driver;
using System.Net.WebSockets;
using System.Text;

namespace BeatEcoprove.Infrastructure.WebSockets;

internal class WebSocketHandler : IWebSocketManager, INotificationSender
{
    private const string InternalServerErrorMessage = "Someting went wrong";

    private readonly ISender _sender;
    private readonly ISessionManager _sessionManager;
    private readonly IMongoCollection<Notification> _mongoCollection;

    public WebSocketHandler(
        ISessionManager sessionManager,
        ISender sender,
        IMongoDatabase mongoDatabase)
    {
        _sessionManager = sessionManager;
        _sender = sender;
        _mongoCollection = mongoDatabase.GetCollection<Notification>("notifications");
    }

    public async Task Handle(
        WebSocket activeSocket, 
        ProfileId userId, 
        CancellationToken cancellationToken = default)
    {
        var buffer = new byte[1024 * 2];

        try
        {
            if (_sessionManager.IsUserAuthenticated(userId))
            {
                await _sessionManager.CloseAsync(userId, cancellationToken);
            }

            _sessionManager.Add(userId, activeSocket);

            while (activeSocket.State == WebSocketState.Open)
            {
                var recivedResult = await activeSocket.ReceiveAsync(buffer, cancellationToken);

                if (recivedResult.CloseStatus.HasValue)
                {
                    break;
                }

                if (!recivedResult.EndOfMessage)
                {
                    continue;
                }

                var message = Encoding.UTF8.GetString(buffer, 0, recivedResult.Count) ?? "";
                var @event = WebSocketEvent.MakeEvent(userId, activeSocket, message, _sender);

                var eventResult = await @event.Handle(cancellationToken);

                if (eventResult.IsError)
                {
                    throw new WebSocketEventHandlerException(eventResult.FirstError.Description);
                }
            }

            if (activeSocket.State != WebSocketState.Closed)
            {
                await _sessionManager.CloseAsync(userId, cancellationToken);
            }
        }
        catch (WebSocketEventException e)
        {
            await _sessionManager.CloseAsync(
                userId,
                WebSocketCloseStatus.InvalidMessageType,
                e.Message,
                cancellationToken);
        }
        catch (WebSocketEventHandlerException e)
        {
            await _sessionManager.CloseAsync(
                userId,
                WebSocketCloseStatus.InvalidPayloadData,
                e.Message,
                cancellationToken);
        }
        catch (Exception)
        {
            await _sessionManager.CloseAsync(
                userId,
                WebSocketCloseStatus.InternalServerError,
                InternalServerErrorMessage,
                cancellationToken);
        }

        activeSocket.Dispose();
    }

    [Obsolete("Obsolete")]
    public async Task SendNotificationAsync(
        ProfileId userId,
        SendNotification notification,
        CancellationToken cancellationToken = default)
    {
        var socket = _sessionManager.Get(userId);

        if (socket == null)
        {
            return;
        }

        if (socket.State != WebSocketState.Open)
        {
            return;
        }

        var responseBytes = Encoding.UTF8.GetBytes(notification);
        await socket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
        WebSocketMessageType.Text,
            true,
            cancellationToken);

        if (notification is InviteToGroupNotification invite)
        {
            await _mongoCollection.InsertOneAsync(
                new Notification(
                    userId,
                    invite.Message,
                    Guid.Parse(invite.GroupId),
                    Guid.Parse(invite.InvitorId),
                    invite.Code
                ),
                cancellationToken);
        }
    }
}
