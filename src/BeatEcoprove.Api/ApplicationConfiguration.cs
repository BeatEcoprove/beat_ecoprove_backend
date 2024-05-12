using BeatEcoprove.Api.Middlewares;
using BeatEcoprove.Application.Shared.Multilanguage;

using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.FileProviders;

namespace BeatEcoprove.Api;

public static class ApplicationConfiguration
{
    private static IApplicationBuilder AddLocalFileStorage(this IApplicationBuilder app)
    {
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "public");

        app.UseStaticFiles(new StaticFileOptions
        {
            OnPrepareResponse = ctx =>
            {
                if (ctx.Context.Request.Path.Value != null && !ctx.Context.Request.Path.Value.EndsWith(".png"))
                {
                    ctx.Context.Response.StatusCode = 404;
                }
            },
            FileProvider = new PhysicalFileProvider(
                path),
            RequestPath = "/public"
        });

        return app;
    }

    private static IApplicationBuilder AddCustomMiddlewares(this IApplicationBuilder app)
    {
        app.UseMiddleware<ProfileCheckerMiddleware>();

        return app;
    }

    private static IApplicationBuilder AddWebSockets(this IApplicationBuilder app)
    {
        app.UseWebSockets();
        app.UseMiddleware<WebSocketsMiddleware>();

        return app;
    }

    private static IApplicationBuilder AddMultiLanguageSupport(this IApplicationBuilder app)
    {
        var supportedCultures = Language.GetSupportedLanguages();

        app.UseRequestLocalization(new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture(Language.Default.Value),
            SupportedCultures = supportedCultures,
            SupportedUICultures = supportedCultures,
            ApplyCurrentCultureToResponseHeaders = true,
            FallBackToParentCultures = true,
            FallBackToParentUICultures = true
        });

        return app;
    }

    public static WebApplication SetupConfiguration(this WebApplication app)
    {
        app.AddMultiLanguageSupport();

        app.UseCors(policyBuilder =>
            policyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers();
        app.AddCustomMiddlewares();

        app.AddLocalFileStorage();
        app.AddWebSockets();
        app.UsePathBase("/api");

        return app;
    }
}