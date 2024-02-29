using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;

namespace BeatEcoprove.Application.Tests.Shared.Mocks;

public class MailSenderMock : IMailSender
{
    private static readonly List<Mail> Mails = new();

    public Task SendMailAsync(Mail mail, CancellationToken cancellationToken = default)
    {
        Mails.Add(mail);
        return Task.CompletedTask;
    }

    public Mail? Last()
    {
        if (Mails.Count == 0)
            return null;

        return Mails.Last();
    }
}