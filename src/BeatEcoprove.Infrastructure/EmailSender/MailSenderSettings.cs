namespace BeatEcoprove.Infrastructure.EmailSender;

public class MailSenderSettings
{
    public const string Section = "MailSenderSettings";
    public string HostEmail { get; set; } = null!;
    public string SmtpServer { get; init; } = null!;
    public int SmtpPort { get; init; }
    public string SmtpUser { get; init; } = null!;
    public string SmtpPassword { get; init; } = null!;
}
