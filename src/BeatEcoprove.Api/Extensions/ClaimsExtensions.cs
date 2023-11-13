﻿using System.Security.Claims;

namespace BeatEcoprove.Api.Extensions;

public static class ClaimsExtensions
{
    public static Guid GetUserId(this ClaimsPrincipal claims)
    {
        var claimList = claims.Claims;

        var userId = claimList
            .FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier);
        
        return Guid.Parse(userId!.Value);
    }
    
    public static string GetEmail(this ClaimsPrincipal claims)
    {
        var claimList = claims.Claims;

        var email = claimList
            .FirstOrDefault(claim => claim.Type == ClaimTypes.Email);

        return email!.Value;
    }
}