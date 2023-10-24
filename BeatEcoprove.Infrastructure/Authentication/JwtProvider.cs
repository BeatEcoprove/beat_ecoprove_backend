using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Infrastructure.Authentication;

public class JwtProvider : IJwtProvider
{
    private const string Algorithm = SecurityAlgorithms.HmacSha256;
    private readonly JwtSettings _jwtSettings;
    private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler = new();

    public JwtProvider(IOptions<JwtSettings> jwtSettings)
    {
        _jwtSettings = jwtSettings.Value;
    }

    public string GenerateToken(TokenPayload payload, Tokens tokenType)
    {
        var signCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey)),
            Algorithm
        );

        var claims = new[]
        {
            new Claim(UserClaims.UserId, payload.UserId),
            new Claim(UserClaims.UserName, payload.UserName),
            new Claim(UserClaims.Email, payload.Email),
            new Claim(UserClaims.AvatarUrl, payload.AvatarUrl),
            new Claim(UserClaims.Level, payload.Level),
            new Claim(UserClaims.LevelPercentage, payload.LevelPercentage),
            new Claim(UserClaims.SustainablePoints, payload.SustainablePoints),
            new Claim(UserClaims.TokenType, tokenType.ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };
        
        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: GetExpireTime(tokenType),
            claims: claims,
            signingCredentials: signCredentials
        );

        return _jwtSecurityTokenHandler.WriteToken(token);
    }

    public async Task<IDictionary<string, string>> GetClaims(string token)
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

    private async Task<bool> ValidateToken(string token)
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