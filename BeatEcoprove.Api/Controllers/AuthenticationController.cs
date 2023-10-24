using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Authentication.Queries.RefreshTokens;
using BeatEcoprove.Contracts.Authentication;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Contracts.Authentication.SignIn;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public AuthenticationController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpPost("signIn/personal")]
    public async Task<ActionResult<AuthenticationResult>> SignInPersonalAccount(SignInPersonalAccountRequest request)
    {
        var resultTokens = 
            await _sender.Send(_mapper.Map<SignInPersonalAccountCommand>(request));

        return resultTokens.Match(
            tokens => Ok(tokens),
            Problem<AuthenticationResult>
        );
    }
    
    [HttpPost("signIn/enterprise")]
    public async Task<ActionResult<AuthenticationResult>> SignInEnterpriseAccount(SignInEnterpriseAccountRequest request)
    {
        var resultTokens = 
            await _sender.Send(_mapper.Map<SignInEnterpriseAccountCommand>(request));

        return resultTokens.Match(
            tokens => Ok(tokens),
            Problem<AuthenticationResult>
        );
    }

    [HttpGet("refresh_tokens")]
    public async Task<ActionResult<AuthenticationResult>> RefreshTokens([FromQuery] string token)
    {
        var resultTokens = 
            await _sender.Send(new RefreshTokensQuery(token));

        return resultTokens.Match(
            tokens => Ok(tokens),
            Problem<AuthenticationResult>
        );
    }
}