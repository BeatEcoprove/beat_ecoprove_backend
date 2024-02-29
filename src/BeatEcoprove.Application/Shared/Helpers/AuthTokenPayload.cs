using System.Globalization;

using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Helpers;

public class AuthTokenPayload : TokenPayload
{
    private readonly Guid _accountId;
    private readonly Guid _profileId;
    private readonly string _email;
    private readonly string _userName;
    private readonly string _avatarUrl;
    private readonly int _level;
    private readonly double _levelPercentage;
    private readonly int _sustainablePoints;
    private readonly int _ecoScore;
    private readonly int _ecoCoins;
    private readonly double _currentXp;
    private readonly double _nextLevelXp;

    public AuthTokenPayload(
        Guid accountId,
        Guid profileId,
        string email,
        string userName,
        string avatarUrl,
        int level,
        double levelPercentage,
        int sustainablePoints,
        int ecoScore,
        int ecoCoins,
        double currentXp,
        double nextLevelXp,
        Tokens tokenType) : base(tokenType)
    {
        _accountId = accountId;
        _profileId = profileId;
        _email = email;
        _userName = userName;
        _avatarUrl = avatarUrl;
        _level = level;
        _levelPercentage = levelPercentage;
        _sustainablePoints = sustainablePoints;
        _ecoScore = ecoScore;
        _ecoCoins = ecoCoins;
        _currentXp = currentXp;
        _nextLevelXp = nextLevelXp;
    }

    public string AccountId => _accountId.ToString();
    public string ProfileId => _profileId.ToString();
    public string Email => _email;
    public string UserName => _userName;
    public string AvatarUrl => _avatarUrl;
    public string Level => _level.ToString();
    public string LevelPercentage => _levelPercentage.ToString(CultureInfo.CurrentCulture);
    public string SustainablePoints => _sustainablePoints.ToString();
    public string EcoScore => _ecoScore.ToString();
    public string EcoCoins => _ecoCoins.ToString();
    public string CurrentXp => _currentXp.ToString(CultureInfo.InvariantCulture);
    public string NextLevelXp => _nextLevelXp.ToString(CultureInfo.InvariantCulture);

    public override IDictionary<string, string> GetPayload()
    {
        return new Dictionary<string, string>
        {
            { UserClaims.AccountId, AccountId },
            { UserClaims.ProfileId, ProfileId },
            { UserClaims.Email, Email },
            { UserClaims.UserName, UserName },
            { UserClaims.AvatarUrl, AvatarUrl },
            { UserClaims.Level, Level },
            { UserClaims.LevelPercentage, LevelPercentage },
            { UserClaims.SustainablePoints, SustainablePoints },
            { UserClaims.EcoScore, EcoScore },
            { UserClaims.EcoCoins, EcoCoins },
            { UserClaims.CurrentXp, CurrentXp },
            { UserClaims.NextLevelXp, NextLevelXp }
        };
    }
}