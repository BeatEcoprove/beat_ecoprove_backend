using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Configuration;

using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Infrastructure.Authentication;

public class JwtProvider : IJwtProvider
{
    private const string Algorithm = SecurityAlgorithms.HmacSha256;
    private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler = new();
    private readonly IGamingService _gamingService;
    private readonly IStoreRepository _storeRepository;

    public JwtProvider(
        IGamingService gamingService, 
        IStoreRepository storeRepository)
    {
        _gamingService = gamingService;
        _storeRepository = storeRepository;
    }

    public string GenerateToken(TokenPayload payload)
    {
        var signCredentials = new SigningCredentials(
           new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Env.Jwt.SecretKey)),
           Algorithm
       );

        if (payload is AuthTokenPayload)
        {
            payload.ExpireAt = GetExpireTime(payload.Type);
        }

        var claims = payload.GetPayload()
            .Select(kvp => new Claim(kvp.Key, kvp.Value));

        claims.Append(new Claim(UserClaims.TokenType, payload.Type.ToString()));
        claims.Append(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

        var token = new JwtSecurityToken(
            issuer: Env.Jwt.JwtIssuer,
            audience: Env.Jwt.JwtAudience,
            expires: payload.ExpireAt,
            claims: claims,
            signingCredentials: signCredentials
        );

        return _jwtSecurityTokenHandler.WriteToken(token);
    }

    public async Task<Dictionary<string, string>> GetClaims(string token)
    {
        if (!await ValidateTokenAsync(token))
        {
            throw new SecurityTokenException();
        }

        return _jwtSecurityTokenHandler
            .ReadJwtToken(token)
            .Claims
            .Select(claim => new KeyValuePair<string, string>(claim.Type, claim.Value))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    public (string, string) GenerateAuthenticationTokens(
        Auth account, 
        Profile profile, 
        ProfileId profileId)
    {
        string role = "";

        if (profile is Employee employee)
        {
            var worker = _storeRepository.GetWorkerByProfileAsync(profile.Id).GetAwaiter().GetResult();

            if (worker is not null)
            {
                role = worker.Role.ToString().ToLower();
            }
        }
        
        var levelProgress = _gamingService.GetLevelProgress(profile);
        var payload = new AuthTokenPayload(
            account.Id,
            profileId,
            account.Email,
            profile.UserName,
            profile.AvatarUrl,
            profile.Level,
            levelProgress,
            profile.SustainabilityPoints,
            profile.EcoScore,
            profile.EcoCoins,
            profile.XP,
            _gamingService.GetNextLevelXp(profile),
            profile.Type,
            Tokens.Access,
            role);

        return GenerateAuthenticationTokens(payload);
    }

    public (string, string) MapClaimsToAuthToken(IDictionary<string, string> claims)
    {
        var payload = new AuthTokenPayload(
            Guid.Parse(claims[UserClaims.AccountId]),
            Guid.Parse(claims[UserClaims.ProfileId]),
            claims[UserClaims.Email],
            claims[UserClaims.UserName],
            claims[UserClaims.AvatarUrl],
            int.Parse(claims[UserClaims.Level]),
            double.Parse(claims[UserClaims.LevelPercentage]),
            int.Parse(claims[UserClaims.SustainablePoints]),
            int.Parse(claims[UserClaims.EcoScore]),
            int.Parse(claims[UserClaims.EcoCoins]),
            double.Parse(claims[UserClaims.CurrentXp]),
            double.Parse(claims[UserClaims.NextLevelXp]),
            UserType.Organization,
            Tokens.Access);

        return GenerateAuthenticationTokens(payload);
    }

    public string GenerateRandomCode(int length)
    {
        var random = new Random();

        var minValue = (int)Math.Pow(10, length - 1);
        var maxValue = (int)Math.Pow(10, length) - 1;
        var code = random.Next(minValue, maxValue + 1);

        return code.ToString("D" + length);
    }

    private (string, string) GenerateAuthenticationTokens(AuthTokenPayload payload)
    {
        var accessToken = GenerateToken(payload);

        payload.Type = Tokens.Refresh;
        var refreshToken = GenerateToken(payload);

        return (accessToken, refreshToken);
    }

    public async Task<bool> ValidateTokenAsync(string token, CancellationToken cancellationToken = default)
    {
        var result =
            await _jwtSecurityTokenHandler.ValidateTokenAsync(token, GetTokenValidationParameters());

        return result.IsValid;
    }

    private DateTime GetExpireTime(Tokens token)
    {
        return token switch
        {
            Tokens.Access => DateTime.Now.AddMinutes(Env.Jwt.JwtAccessTokenExpiration),
            Tokens.Refresh => DateTime.Now.AddDays(Env.Jwt.JwtRefreshTokenExpiration),
            _ => throw new Exception("Invalid token type")
        };
    }

    public static TokenValidationParameters GetTokenValidationParameters()
    {
        return new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = Env.Jwt.JwtIssuer,
            ValidateAudience = true,
            ValidAudience = Env.Jwt.JwtAudience,
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(Env.Jwt.SecretKey)),
            ValidateIssuerSigningKey = true
        };
    }
}