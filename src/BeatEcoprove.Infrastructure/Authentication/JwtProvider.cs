using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Infrastructure.Authentication;

public class JwtProvider : IJwtProvider
{
    private const string Algorithm = SecurityAlgorithms.HmacSha256;
    private readonly JwtSettings _jwtSettings;
    private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler = new();
    private readonly IGamingService _gamingService;

    public JwtProvider(
        IOptions<JwtSettings> jwtSettings, 
        IGamingService gamingService)
    {
        _jwtSettings = jwtSettings.Value;
        _gamingService = gamingService;
    }

    public string GenerateToken(TokenPayload payload)
    {
        var signCredentials = new SigningCredentials(
           new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey)),
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
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: payload.ExpireAt,
            claims: claims,
            signingCredentials: signCredentials
        );

        return _jwtSecurityTokenHandler.WriteToken(token);
    }

    public async Task<Dictionary<string, string>> GetClaims(string token)
    {
        if (!await ValidateToken(token))
        {
            throw new SecurityTokenException();
        }

        return _jwtSecurityTokenHandler
            .ReadJwtToken(token)
            .Claims
            .Select(claim => new KeyValuePair<string, string>(claim.Type, claim.Value))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    public (string, string) GenerateAuthenticationTokens(Auth account, Profile profile)
    {
        var ola = _gamingService.GetLevelProgress(profile);
        var payload = new AuthTokenPayload(
            account.Id,
            account.Email,
            profile.UserName,
            profile.AvatarUrl,
            profile.Level,
            ola,
            profile.SustainabilityPoints,
            profile.EcoScore,
            profile.EcoCoins,
            profile.XP,
            _gamingService.GetNextLevelXp(profile),
            Tokens.Access);
        
       return GenerateAuthenticationTokens(payload);
    }
    
    public (string, string) MapClaimsToAuthToken(IDictionary<string, string> claims)
    {
        var payload = new AuthTokenPayload(
            Guid.Parse(claims[UserClaims.AccountId]),
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

    public async Task<bool> ValidateToken(string token)
    {
        var result =
            await _jwtSecurityTokenHandler.ValidateTokenAsync(token, GetTokenValidationParameters(_jwtSettings));

        return result.IsValid;
    }

    private DateTime GetExpireTime(Tokens token)
    {
        return token switch
        {
            Tokens.Access => DateTime.Now.AddMinutes(_jwtSettings.AccessTokenExpirationInMinutes),
            Tokens.Refresh => DateTime.Now.AddDays(_jwtSettings.RefreshTokenExpirationInDays),
            _ => throw new Exception("Invalid token type")
        };
    }

    public static TokenValidationParameters GetTokenValidationParameters(JwtSettings jwtSettings)
    {
        return new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidateAudience = true,
            ValidAudience = jwtSettings.Audience,
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
            ValidateIssuerSigningKey = true
        };
    }
}