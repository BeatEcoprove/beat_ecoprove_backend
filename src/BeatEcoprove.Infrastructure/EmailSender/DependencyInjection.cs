using BeatEcoprove.Application;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BeatEcoprove.Infrastructure.EmailSender;

public static class DependencyInjection
{
    public static IServiceCollection AddEmailSender(
        this IServiceCollection services,
        IConfiguration configuration)
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
}
