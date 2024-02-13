﻿using BeatEcoprove.Application.Shared.Communication;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.WebSockets.Events;
using BeatEcoprove.Infrastructure.WebSockets.Exceptions;
using ErrorOr;
using MediatR;
using System.Net.WebSockets;
using System.Text;

namespace BeatEcoprove.Infrastructure.WebSockets;

internal class WebSocketHandler : 
    IWebSocketManager, 
    INotificationSender
{
    private const string InternalServerErrorMessage = "Someting went wrong";

    private readonly ISender _sender;
    private readonly ISessionManager _sessionManager;
    private readonly INotificationRepository _notificationRepository;

    public WebSocketHandler(
        ISessionManager sessionManager,
        ISender sender,
        INotificationRepository notificationRepository)
    {
        _sessionManager = sessionManager;
        _sender = sender;
        _notificationRepository = notificationRepository;
    }

    [Obsolete]
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
                    var error = eventResult.FirstError;

                    if (error.Type == ErrorType.Conflict)
                    {
                        await NotifyClient(
                            new MessageNotificationEvent(
                                userId,
                                error.Description
                            ),
                            cancellationToken
                        );

                        continue;
                    }

                    throw new WebSocketEventHandlerException(error.Description);
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

    private async Task HandleNotification(
        IRealTimeNotification notification,
        WebSocketMessageType type = WebSocketMessageType.Text,
        CancellationToken cancellationToken = default)
    {
        var socket = _sessionManager.Get(notification.Owner);

        if (socket == null)
        {
            return;
        }

        if (socket.State != WebSocketState.Open)
        {
            return;
        }

        var responseBytes = Encoding.UTF8.GetBytes(notification.ConvertToJson());
        await socket.SendAsync(new ArraySegment<byte>(responseBytes, 0, responseBytes.Length),
            type,
            true,
            cancellationToken);
    }

    public async Task NotifyClient<TContent>(
        NotificationEvent<TContent> @event, 
        CancellationToken cancellationToken = default)
    {
        await HandleNotification(
            @event, 
            cancellationToken: cancellationToken
        );
    }

    public async Task SendNotificationAsync(
        INotifer notification, 
        CancellationToken cancellationToken = default)
    {
        var content = notification.GetNotification();

        await HandleNotification(
            notification,
            cancellationToken: cancellationToken
        );

        await _notificationRepository.AddAsync(content, cancellationToken);
    }
}