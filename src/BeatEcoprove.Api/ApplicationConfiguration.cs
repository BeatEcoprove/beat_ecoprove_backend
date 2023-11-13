﻿using BeatEcoprove.Api.Middlewares;
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
    
    public static WebApplication SetupConfiguration(this WebApplication app)
    {
        app.UseCors(policyBuilder => 
            policyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers();
        app.AddCustomMiddlewares();

        app.AddLocalFileStorage();
        
        return app;
    }
}