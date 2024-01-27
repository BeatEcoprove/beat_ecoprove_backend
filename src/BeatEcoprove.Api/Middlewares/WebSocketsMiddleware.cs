using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Middlewares;

public class WebSocketsMiddleware  : ControllerBase, IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (!context.WebSockets.IsWebSocketRequest)
        {
            await next(context);
            return;
        }
            
        if (context.User.Identity?.IsAuthenticated != true)
        {
            context.Response.StatusCode = 401;
            return;
        }
            
        var authId = context.User.GetUserId();
        var authRepository = context.RequestServices.GetService<IAuthRepository>();

        var profile = await authRepository?.GetMainProfile(AuthId.Create(authId))!;

        if (profile is null)
        {
            context.Response.StatusCode = 401;
            return;
        }
            
        var webSocket = await context.WebSockets.AcceptWebSocketAsync();
        var webSocketHandler = context.RequestServices.GetService<IWebSocketManager>();
            
        await webSocketHandler?.Handle(webSocket, profile.Id)!;
    }
}