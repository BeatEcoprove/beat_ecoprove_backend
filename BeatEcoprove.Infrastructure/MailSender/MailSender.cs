using BeatEcoprove.Application;
using FluentEmail.Core;

namespace BeatEcoprove.Infrastructure;

public class MailSender : IMailSender
{
    private readonly IFluentEmail _fluentEmail;

    public MailSender(IFluentEmail fluentEmail)
    {
        _fluentEmail = fluentEmail;
    }

    public async Task SendMailAsync(string to, string subject, string body)
    {
        await _fluentEmail
            .To(to)
            .Subject(subject)
            .Body(body, isHtml: false)
            .SendAsync();
    }
}
