using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Infrastructure.Configuration;

using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure.EmailSender;

public static class DependencyInjection
{
    public static IServiceCollection AddEmailSender(
        this IServiceCollection services)
    {
        services.AddScoped<IMailSender, MailSender>();

        services.AddFluentEmail(Env.Smtp.Email)
            .AddSmtpSender(
                Env.Smtp.Host,
                Env.Smtp.Port,
                Env.Smtp.User,
                Env.Smtp.Password);

        return services;
    }
}