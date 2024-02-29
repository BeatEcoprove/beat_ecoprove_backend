namespace BeatEcoprove.Infrastructure.Configuration;

public partial class Env
{
    public class Postgres
    {
        public static string Database => GetString("POSTGRES_DB");
        public static string User => GetString("POSTGRES_USER");
        public static string Password => GetString("POSTGRES_PASSWORD");
        public static string Port => GetString("POSTGRES_PORT");
        public static string Host => GetString("POSTGRES_HOST");
        public static string ConnectionString { get; set; } = $"Host={Host};Port={Port};Username={User};Password={Password};Database={Database};";
    }
}