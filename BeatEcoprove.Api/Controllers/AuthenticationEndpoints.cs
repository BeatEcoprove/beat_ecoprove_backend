using BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;
using BeatEcoprove.Contracts.Authentication.SignIn;
using MapsterMapper;
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

    private static async Task<IResult> RegisterPersonalAccount(SignInPersonalAccountRequest request, ISender sender, IMapper mapper)
    {
        var tokens = await sender.Send(mapper.Map<SignInPersonalAccountCommand>(request));

        return Results.Ok(tokens);
    }
}