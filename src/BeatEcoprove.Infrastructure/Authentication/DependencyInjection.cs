using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure.Authentication;

public static class DependencyInjection
{
    public static IServiceCollection AddBeatAuth(
        this IServiceCollection services)
    {
        services.AddAuthentication(
            options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = JwtProvider.GetTokenValidationParameters();
            });

        return services;
    }
}