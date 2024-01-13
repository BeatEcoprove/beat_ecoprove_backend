namespace BeatEcoprove.Application.Shared.Helpers;

public struct UserClaims
{
    public const string AccountId = "sub";
    public const string Email = "email";
    public const string UserName = "given_name";
    public const string AvatarUrl = "avatar_url";
    public const string Level = "level";
    public const string LevelPercentage = "level_percentage";
    public const string SustainablePoints = "sustainable_points";
    public const string TokenType = "token_type";
    public static string EcoScore = "eco_score";
    public static string EcoCoins = "eco_coins";
}