using System.Net;
using System.Text.Json;

using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Api.Middlewares;
public class ProfileCheckerMiddleware : ControllerBase, IMiddleware
{
    private const string ProfileIdKey = "profileId";

    private readonly IAuthRepository _authRepository;
    private readonly IJwtProvider _jwtProvider;

    public ProfileCheckerMiddleware(
        IAuthRepository authRepository,
        IJwtProvider jwtProvider)
    {
        _authRepository = authRepository;
        _jwtProvider = jwtProvider;
    }

    private async Task<ErrorOr<bool>> IsProfileValid(AuthId authId, ProfileId profileId, CancellationToken cancellationToken = default)
    {
        return await _authRepository
               .DoesProfileBelongToAuth(authId, ProfileId.Create(profileId), cancellationToken);
    }

    private async Task<ErrorOr<Email>> GetEmailFromAccessToken(HttpContext context)
    {
        IDictionary<string, string> claims;

        var accessToken = context.Request.Headers["Authorization"].ToString().Split(" ")[1];

        try
        {
            claims = await _jwtProvider.GetClaims(accessToken);
        }
        catch (SecurityTokenException)
        {
            return Errors.Token.InvalidRefreshToken;
        }

        return Email.Create(claims[UserClaims.Email]);
    }

    private Task ReturnUnAuthorized(HttpContext context, string message)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

        var response = JsonSerializer.Serialize(
            new ProblemDetails
            {
                Status = context.Response.StatusCode,
                Title = message,
            });

        return context.Response.WriteAsync(response);
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var profileIdValue =
            context.Request.RouteValues[ProfileIdKey]?.ToString();

        if (string.IsNullOrWhiteSpace(profileIdValue) && !Guid.TryParse(profileIdValue, out _))
        {
            await next(context);
            return;
        }

        var email = await GetEmailFromAccessToken(context);

        if (email.IsError)
        {
            await ReturnUnAuthorized(context, email.FirstError.Description);
            return;
        }

        var auth = await _authRepository.GetAuthByEmail(email.Value, default);

        if (auth is null)
        {
            await ReturnUnAuthorized(context, Errors.User.ProfileDoesNotBelongToAuth.Description);
            return;
        }

        var isProfileValid = await IsProfileValid(AuthId.Create(auth.Id), ProfileId.Create(Guid.Parse(profileIdValue!)));

        if (isProfileValid.IsError)
        {
            await ReturnUnAuthorized(context, isProfileValid.FirstError.Description);
            return;
        }

        if (!isProfileValid.Value)
        {
            await ReturnUnAuthorized(context, Errors.User.ProfileDoesNotBelongToAuth.Description);
            return;
        }

        await next(context);
    }

}