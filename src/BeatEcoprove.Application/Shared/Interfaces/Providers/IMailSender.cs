namespace BeatEcoprove.Application;

public interface IMailSender
{
    Task SendMailAsync(string to, string subject, string body);
}
