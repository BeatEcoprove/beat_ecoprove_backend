namespace BeatEcoprove.Infrastructure;

public class DbSettings
{
    public const string Section = "DbSettings";
    public string ConnectionString { get; set; } = null!;
}