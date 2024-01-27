using BeatEcoprove.Application;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Infrastructure.Authentication;
using BeatEcoprove.Infrastructure.BackgroundJobs;
using BeatEcoprove.Infrastructure.EmailSender;
using BeatEcoprove.Infrastructure.FileStorage;
using BeatEcoprove.Infrastructure.Gaming;
using BeatEcoprove.Infrastructure.Persistence;
using BeatEcoprove.Infrastructure.Persistence.Interceptors;
using BeatEcoprove.Infrastructure.Persistence.Repositories;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using BeatEcoprove.Infrastructure.Providers;
using BeatEcoprove.Infrastructure.Services;
using BeatEcoprove.Infrastructure.WebSockets;
using BeatEcoprove.Infrastructure.WebSockets.Handlers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace BeatEcoprove.Infrastructure;

public static class DependencyInjection
{
    private static IServiceCollection AddBackgroundJobs(this IServiceCollection services)
    {
        services.AddSingleton<ConnectionManager>();
        services.AddHostedService<PgNotificationListener>();
        
        services.AddScoped<IWebSocketManager, WebSocketManager>();
        services.AddScoped<AuthenticationHandler>();
        services.AddScoped<ChatGroupHandler>();
        services.AddScoped<INotificationSender>(provider => provider.GetService<AuthenticationHandler>()!);

        return services;
    }
    
   private static IServiceCollection AddRedisConfiguration(
       this IServiceCollection services, ConfigurationManager configuration)
   {
       var redisHost = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "localhost";
       var redisPort = Environment.GetEnvironmentVariable("REDIS_PORT") ?? "6379";
   
       services.AddScoped<IDatabase>(cfg =>
       {
           var options = new ConfigurationOptions
           {
               EndPoints = { $"{redisHost}:{redisPort}" },
               AbortOnConnectFail = false,
               ConnectTimeout = 5000,
           };
   
           IConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(options);
           var database = multiplexer.GetDatabase(db: 0);
           
           return database;
       });
   
       return services;
   }
    
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
                Environment.GetEnvironmentVariable("SmtpUser") ?? mailSenderSettings.SmtpUser,
                Environment.GetEnvironmentVariable("SmtpPassword") ?? mailSenderSettings.SmtpPassword);

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
        
        services.AddScoped<SoftDeleteInterceptor>();
        services.AddScoped<PublishDomainEventsInterceptor>();

        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IClothRepository, ClothRepository>();
        services.AddScoped<IBucketRepository, BucketRepository>();
        services.AddScoped<IColorRepository, ColorRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<IActivityRepository, ActionRepository>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        services.AddScoped<IMaintenanceServiceRepository, MaintenanceServiceRepository>();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IValidationFieldService, ValidationService>();
        services.AddScoped<IAuthorizationFacade, AuthorizationFacade>();
        services.AddScoped<IProfileManager, ProfileManager>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IClosetService, ClosetService>();
        services.AddScoped<IGamingService, GamingService>();
        services.AddScoped<IGroupService, GroupService>();

        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddRedisConfiguration(configuration);
        services.AddProviders();
        services.AddEmailConfiguration(configuration);
        services.AddFileStorageConfiguration(configuration);
        services.AddPersistence(configuration);
        services.AddAuth(configuration);
        services.AddServices();
        services.AddBackgroundJobs();

        return services;
    }
}