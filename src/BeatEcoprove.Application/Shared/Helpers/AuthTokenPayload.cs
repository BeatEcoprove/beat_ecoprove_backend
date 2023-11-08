using System.Globalization;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Helpers;

public class AuthTokenPayload : TokenPayload
{
    private readonly Guid _userId;
    private readonly string _email;
    private readonly string _userName;
    private readonly string _avatarUrl;
    private readonly int _level;
    private readonly double _levelPercentage;
    private readonly int _sustainablePoints;

    public AuthTokenPayload(
        Guid userId,
        string email,
        string userName,
        string avatarUrl,
        int level,
        double levelPercentage,
        int sustainablePoints,
        Tokens tokenType) : base(tokenType)
    {
        _userId = userId;
        _email = email;
        _userName = userName;
        _avatarUrl = avatarUrl;
        _level = level;
        _levelPercentage = levelPercentage;
        _sustainablePoints = sustainablePoints;
    }

    public string UserId => _userId.ToString();
    public string Email => _email;
    public string UserName => _userName;
    public string AvatarUrl => _avatarUrl;
    public string Level => _level.ToString();
    public string LevelPercentage => _levelPercentage.ToString(CultureInfo.CurrentCulture);
    public string SustainablePoints => _sustainablePoints.ToString();

    public override IDictionary<string, string> GetPayload()
    {
        return new Dictionary<string, string>
        {
            { UserClaims.UserId, UserId },
            { UserClaims.Email, Email },
            { UserClaims.UserName, UserName },
            { UserClaims.AvatarUrl, AvatarUrl },
            { UserClaims.Level, Level },
            { UserClaims.LevelPercentage, LevelPercentage },
            { UserClaims.SustainablePoints, SustainablePoints }
        };
    }
}
