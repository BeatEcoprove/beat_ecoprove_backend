using BeatEcoprove.Application;
using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Application.Authentication.Queries.RefreshTokens;
using BeatEcoprove.Contracts;
using BeatEcoprove.Contracts.Authentication;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Contracts.Authentication.SignIn;
using Mapster;
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

    [HttpPost("login")]
    public async Task<ActionResult<AuthenticationResult>> LoginToAccount(LoginRequest request)
    {
        var resultTokens =
            await _sender.Send(_mapper.Map<LoginQuery>(request));

        return resultTokens.Match(
            tokens => Ok(tokens),
            Problem<AuthenticationResult>
        );
    }

    [HttpPost("signIn/personal")]
    public async Task<ActionResult<AuthenticationResult>> SignInPersonalAccount([FromForm] SignInPersonalAccountRequest request)
    {
        var resultTokens =
            await _sender.Send(_mapper.Map<SignInPersonalAccountCommand>(request));

        return resultTokens.Match(
            tokens => Created("", tokens),
            Problem<AuthenticationResult>
        );
    }

    [HttpPost("signIn/enterprise")]
    public async Task<ActionResult<AuthenticationResult>> SignInEnterpriseAccount([FromForm] SignInEnterpriseAccountRequest request)
    {
        var resultTokens =
            await _sender.Send(_mapper.Map<SignInEnterpriseAccountCommand>(request));

        return resultTokens.Match(
            tokens => Created("", tokens),
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

    [HttpPost("forgot_password")]
    public async Task<ActionResult<string>> ForgotPassword(ForgotPasswordRequest request)
    {
        var resultMessage =
            await _sender.Send(_mapper.Map<ForgotPasswordCommand>(request));

        return resultMessage.Match(
            message => Ok(),
            Problem<string>
        );
    }

    [HttpPost("reset_password")]
    public async Task<ActionResult<string>> ResetPassword(ResetPasswordRequest request, [FromQuery] string forgotToken)
    {
        var resultMessage =
            await _sender.Send(new
            {
                request.Password,
                ForgotToken = forgotToken,
            }.Adapt<ResetPasswordCommand>());

        return resultMessage.Match(
            message => Ok(),
            Problem<string>
        );
    }
}