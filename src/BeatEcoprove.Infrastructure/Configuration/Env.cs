namespace BeatEcoprove.Infrastructure.Configuration;

public partial class Env
{
    private static string GetString(string envName, string fallback = "")
    {
        return Environment.GetEnvironmentVariable(envName) ?? fallback;
    }

    private static int GetInteger(string envName, int fallback = 0)
    {
        var value = Environment.GetEnvironmentVariable(envName);

        return value != null ? int.Parse(value) : fallback;
    }
}