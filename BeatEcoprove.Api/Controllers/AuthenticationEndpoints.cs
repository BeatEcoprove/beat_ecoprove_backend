using BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;
using BeatEcoprove.Contracts.Authentication.SignIn;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

public static class AuthenticationEndpoints
{
    public static void MapAuthenticationEndpoints(this IEndpointRouteBuilder app)
    {
        var authGroup = app.MapGroup("auth");
        
        authGroup.MapPost("signIn/personal", RegisterPersonalAccount);
    }

    private static async Task<IResult> RegisterPersonalAccount(SignInPersonalAccountRequest request, ISender sender)
    {
        var tokens = await sender.Send(new SignInPersonalAccountCommand(
            request.Name,
            request.BornDate,
            request.Gender,
            request.Phone,
            request.UserName,
            request.AvatarUrl,
            request.Email,
            request.Password));

        return Results.Ok(tokens);
    }
}