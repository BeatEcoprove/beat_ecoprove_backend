namespace BeatEcoprove.Infrastructure.Configuration;

public abstract partial class Env
{
    public abstract class Mongo
    {
        public static string User => GetString("MONGO_DEFAULT_USER", "beat");
        public static string Password => GetString("MONGO_DEFAULT_PASSWORD", "password");
        public static string Database => GetString("MONGO_INITDB_DATABASE", "ecoprove");
        public static string Port => GetString("MONGO_PORT", "27017");
        public static string Host { get; set; } = GetString("MONGO_HOST", "localhost");
        public static string ConnectionString { get; set; } = $"mongodb://{User}:{Password}@{Host}:{Port}/{Database}";
    }
}