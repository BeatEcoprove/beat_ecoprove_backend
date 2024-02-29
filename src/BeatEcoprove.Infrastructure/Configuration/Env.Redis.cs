namespace BeatEcoprove.Infrastructure.Configuration;

public partial class Env
{
    public class Redis
    {
        public static string Host { get; set; } = GetString("REDIS_HOST", "localhost");
        public static string Port => GetString("REDIS_PORT", "6379");
        public static int Database => GetInteger("REDIS_DATABASE", 0);
        public static string ConnectionString { get; set; } = $"{Host}:{Port}";
    }
}