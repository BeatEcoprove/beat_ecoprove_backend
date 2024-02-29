using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IMailSender
{
    Task SendMailAsync(Mail mail, CancellationToken cancellationToken = default);
    Mail? Last();
}