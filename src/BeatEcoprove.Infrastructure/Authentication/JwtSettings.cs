namespace BeatEcoprove.Infrastructure.Authentication;

public class JwtSettings
{
    public const string Section = "JwtSettings";
    public string Issuer { get; init; } = null!;
    public string Audience { get; init; } = null!;
    public string SecretKey { get; init; } = null!;
    public int AccessTokenExpirationInMinutes { get; init; }
    public int RefreshTokenExpirationInDays { get; init; }
}