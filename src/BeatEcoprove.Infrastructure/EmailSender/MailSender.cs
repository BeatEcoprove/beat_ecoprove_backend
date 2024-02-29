using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;

using FluentEmail.Core;

namespace BeatEcoprove.Infrastructure.EmailSender;

public class MailSender : IMailSender
{
    private readonly IFluentEmail _fluentEmail;
    private static readonly List<Mail> Mails = new();

    public MailSender(IFluentEmail fluentEmail)
    {
        _fluentEmail = fluentEmail;
    }

    public async Task SendMailAsync(Mail mail, CancellationToken cancellationToken = default)
    {
        await _fluentEmail
            .To(mail.To)
            .Subject(mail.Subject)
            .Body(mail.Body, isHtml: false)
            .SendAsync(cancellationToken);

        Mails.Add(mail);
    }

    public Mail? Last()
    {
        return Mails.Count == 0 ? null : Mails.Last();
    }
}