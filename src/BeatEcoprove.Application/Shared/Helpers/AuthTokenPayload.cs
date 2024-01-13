﻿using System.Globalization;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Helpers;

public class AuthTokenPayload : TokenPayload
{
    private readonly Guid _accountId;
    private readonly string _email;
    private readonly string _userName;
    private readonly string _avatarUrl;
    private readonly int _level;
    private readonly double _levelPercentage;
    private readonly int _sustainablePoints;
    private readonly int _ecoScore;
    private readonly int _ecoCoins;

    public AuthTokenPayload(
        Guid accountId,
        string email,
        string userName,
        string avatarUrl,
        int level,
        double levelPercentage,
        int sustainablePoints,
        int ecoScore,
        int ecoCoins,
        Tokens tokenType) : base(tokenType)
    {
        _accountId = accountId;
        _email = email;
        _userName = userName;
        _avatarUrl = avatarUrl;
        _level = level;
        _levelPercentage = levelPercentage;
        _sustainablePoints = sustainablePoints;
        _ecoScore = ecoScore;
        _ecoCoins = ecoCoins;
    }

    public string AccountId => _accountId.ToString();
    public string Email => _email;
    public string UserName => _userName;
    public string AvatarUrl => _avatarUrl;
    public string Level => _level.ToString();
    public string LevelPercentage => _levelPercentage.ToString(CultureInfo.CurrentCulture);
    public string SustainablePoints => _sustainablePoints.ToString();
    public string EcoScore => _ecoScore.ToString();
    public string EcoCoins => _ecoCoins.ToString();

    public override IDictionary<string, string> GetPayload()
    {
        return new Dictionary<string, string>
        {
            { UserClaims.AccountId, AccountId },
            { UserClaims.Email, Email },
            { UserClaims.UserName, UserName },
            { UserClaims.AvatarUrl, AvatarUrl },
            { UserClaims.Level, Level },
            { UserClaims.LevelPercentage, LevelPercentage },
            { UserClaims.SustainablePoints, SustainablePoints },
            { UserClaims.EcoScore, EcoScore },
            { UserClaims.EcoCoins, EcoCoins }
        };
    }
}
