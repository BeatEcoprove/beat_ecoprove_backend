﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BeatEcoprove.Application;
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