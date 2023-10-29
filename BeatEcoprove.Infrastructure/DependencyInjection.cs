using BeatEcoprove.Application;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Infrastructure.Authentication;
using BeatEcoprove.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BeatEcoprove.Infrastructure;

public static class DependencyInjection
{
    private static IServiceCollection AddAuth(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var jwtSettings = new JwtSettings();
        configuration.Bind(JwtSettings.Section, jwtSettings);
        services.AddSingleton(Options.Create(jwtSettings));

        services.AddAuthentication(
            options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = JwtProvider.GetTokenValidationParameters(jwtSettings);
        });

        return services;
    }

    private static IServiceCollection AddProviders(
        this IServiceCollection services)
    {
        services.AddScoped<IJwtProvider, JwtProvider>();
        services.AddScoped<IPasswordProvider, PasswordProvider>();

        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, ConfigurationManager configurationManager)
    {
        var dbSettings = new DbSettings();
        configurationManager.Bind(DbSettings.Section, dbSettings);
        services.AddSingleton(Options.Create(dbSettings));

        services.AddDbContext<BeatEcoproveDbContext>();
        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<BeatEcoproveDbContext>()!);
        services.AddScoped<IUnitOfWork>(provider => provider.GetService<BeatEcoproveDbContext>()!);

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddProviders();
        services.AddPersistence(configuration);
        services.AddAuth(configuration);

        return services;
    }
}