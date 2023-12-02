using BeatEcoprove.Application;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Infrastructure.Authentication;
using BeatEcoprove.Infrastructure.EmailSender;
using BeatEcoprove.Infrastructure.FileStorage;
using BeatEcoprove.Infrastructure.Persistence;
using BeatEcoprove.Infrastructure.Persistence.Repositories;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using BeatEcoprove.Infrastructure.Providers;
using BeatEcoprove.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BeatEcoprove.Infrastructure;

public static class DependencyInjection
{
    private static IServiceCollection AddEmailConfiguration(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        var mailSenderSettings = new MailSenderSettings();
        configuration.Bind(MailSenderSettings.Section, mailSenderSettings);
        services.AddSingleton(Options.Create(mailSenderSettings));

        services.AddScoped<IMailSender, MailSender>();

        services.AddFluentEmail(
                mailSenderSettings.HostEmail)
            .AddSmtpSender(
                mailSenderSettings.SmtpServer,
                mailSenderSettings.SmtpPort,
                mailSenderSettings.SmtpUser,
                mailSenderSettings.SmtpPassword);

        return services;
    }

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

    private static IServiceCollection AddFileStorageConfiguration(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        var mailSenderSettings = new LocalFileStorageSettings
        {
            BaseUrl = "http://localhost:5182",
            FolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "public"),
            PublicFolder = "public"
        };

        services.AddSingleton(Options.Create(mailSenderSettings));

        services.AddScoped<IFileStorageProvider, LocalFileStorageProvider>();

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

        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IClothRepository, ClothRepository>();
        services.AddScoped<IBucketRepository, BucketRepository>();
        services.AddScoped<IColorRepository, ColorRepository>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IValidationFieldService, ValidationService>();
        services.AddScoped<IAuthorizationFacade, AuthorizationFacade>();
        services.AddScoped<IProfileManager, ProfileManager>();

        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddProviders();
        services.AddEmailConfiguration(configuration);
        services.AddFileStorageConfiguration(configuration);
        services.AddPersistence(configuration);
        services.AddAuth(configuration);
        services.AddServices();

        return services;
    }
}