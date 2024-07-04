using System.Globalization;

using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;

namespace BeatEcoprove.Application.Shared.Helpers;

public class AuthTokenPayload : TokenPayload
{
    private readonly Guid _accountId;
    private readonly Guid _profileId;
    private readonly int _level;
    private readonly double _levelPercentage;
    private readonly int _sustainablePoints;
    private readonly int _ecoScore;
    private readonly int _ecoCoins;
    private readonly double _currentXp;
    private readonly double _nextLevelXp;
    private readonly string _role;

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
        UserType userType,
        Tokens tokenType,
        string role = "") : base(tokenType)
    {
        _role = role;
        _accountId = accountId;
        _profileId = profileId;
        Email = email;
        UserName = userName;
        AvatarUrl = avatarUrl;
        _level = level;
        _levelPercentage = levelPercentage;
        _sustainablePoints = sustainablePoints;
        _ecoScore = ecoScore;
        _ecoCoins = ecoCoins;
        _currentXp = currentXp;
        _nextLevelXp = nextLevelXp;
        UserType = userType;
    }

    public string AccountId => _accountId.ToString();
    public string ProfileId => _profileId.ToString();
    public string Email { get; }
    public string UserName { get; }
    public string AvatarUrl { get; }
    public UserType UserType { get; }
    public string Level => _level.ToString();
    public string LevelPercentage => _levelPercentage.ToString(CultureInfo.CurrentCulture);
    public string SustainablePoints => _sustainablePoints.ToString();
    public string EcoScore => _ecoScore.ToString();
    public string EcoCoins => _ecoCoins.ToString();
    public string CurrentXp => _currentXp.ToString(CultureInfo.InvariantCulture);
    public string NextLevelXp => _nextLevelXp.ToString(CultureInfo.InvariantCulture);

    public override IDictionary<string, string> GetPayload()
    {
        var userType = UserType.GetUserType();
        
        var claims = new Dictionary<string, string>
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
            { UserClaims.NextLevelXp, NextLevelXp },
            { UserClaims.Type, userType } 
        };

        if (UserType.Equals(UserType.Employee))
        {
            claims.Add(UserClaims.Role, _role);
        }
        
        return claims;
    }
}