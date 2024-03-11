using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Authentication.Commands.ResetPassword;
using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Application.Authentication.Queries.RefreshTokens;
using BeatEcoprove.Application.Authentication.Queries.ValidationField;
using BeatEcoprove.Application.Shared.Multilanguage;
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

    public AuthenticationController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture)
        : base(languageCulture)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("validate/check-field")]
    public async Task<ActionResult<FieldValidationResponse>> ValidateField([FromQuery] string fieldName, [FromQuery] string value)
    {
        var fieldValidationResult =
            await _sender.Send(new
            {
                FieldName = fieldName,
                Value = value,
            }.Adapt<ValidationFieldQuery>());

        return fieldValidationResult.Match(
            fieldValidationResponse => Ok(fieldValidationResponse),
            Problem<FieldValidationResponse>
        );
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
    public async Task<ActionResult<AuthenticationResult>> RefreshTokens(
        [FromQuery] string token,
        [FromQuery] Guid profileId)
    {
        var resultTokens =
            await _sender.Send(new RefreshTokensQuery(token, profileId));

        return resultTokens.Match(
            tokens => Ok(tokens),
            Problem<AuthenticationResult>
        );
    }

    [HttpPost("forgot_password")]
    public async Task<ActionResult<DefaultResponse>> ForgotPassword(ForgotPasswordRequest request)
    {
        var resultMessage =
            await _sender.Send(_mapper.Map<ForgotPasswordCommand>(request));

        return resultMessage.Match(
            message => Ok(new DefaultResponse(message)),
            Problem<DefaultResponse>
        );
    }

    [HttpPost("reset_password")]
    public async Task<ActionResult<DefaultResponse>> ResetPassword(ResetPasswordRequest request, [FromQuery] string code)
    {
        var resultMessage =
            await _sender.Send(new
            {
                request.Password,
                Code = code,
            }.Adapt<ResetPasswordCommand>());

        return resultMessage.Match(
            message => Ok(new DefaultResponse(message)),
            Problem<DefaultResponse>
        );
    }
}