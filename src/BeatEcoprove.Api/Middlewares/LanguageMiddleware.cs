using System.Globalization;

using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Middlewares;

public class LanguageMiddleware : ControllerBase, IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        // Get Accept-Language header
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");

        await next(context);
    }
}