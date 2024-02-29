namespace BeatEcoprove.Infrastructure.Configuration;

public partial class Env
{
    public class Smtp
    {
        public static string Email => GetString("SMTP_HOST_EMAIL");
        public static string Host => GetString("SMTP_HOST");
        public static int Port => GetInteger("SMTP_PORT");
        public static string User => GetString("SMTP_HOST_USER");
        public static string Password => GetString("SMTP_HOST_PASSWORD");
    }
}