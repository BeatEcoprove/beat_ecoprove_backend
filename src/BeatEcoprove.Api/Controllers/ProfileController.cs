using Asp.Versioning;

using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Profiles.Commands.CreateNestedProfile;
using BeatEcoprove.Application.Profiles.Commands.DeleteNestedProfile;
using BeatEcoprove.Application.Profiles.Commands.PromoteProfileToAccount;
using BeatEcoprove.Application.Profiles.Commands.UpdateProfile;
using BeatEcoprove.Application.Profiles.Queries.GetAllProfiles;
using BeatEcoprove.Application.Profiles.Queries.GetMyProfiles;
using BeatEcoprove.Application.Profiles.Queries.GetProfile;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.Profile;

using Mapster;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Authorize]
[Route("v{version:apiVersion}/profiles")]
public class ProfileController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public ProfileController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture) : base(languageCulture)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("all")]
    public async Task<ActionResult<AllProfilesResponse>> GetAllProfiles(
        [FromQuery] Guid profileId,
        [FromQuery] string? search,
        [FromQuery] int? page = 1,
        [FromQuery] int? pageSize = 10,
        CancellationToken cancellationToken = default
    )
    {
        var authId = HttpContext.User.GetUserId();

        var profiles = await _sender
            .Send(new GetAllProfilesQuery(
                authId,
                profileId,
                search,
                page ?? 1,
                pageSize ?? 10
                ), cancellationToken);

        return profiles.Match(
            response => Ok(new AllProfilesResponse(response.Adapt<List<ProfileResponse>>())),
            Problem<AllProfilesResponse>
        );
    }

    [HttpGet("{username}")]
    public async Task<ActionResult<ProfileResponse>> GetProfile(
        string username,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();

        var profiles = await _sender
            .Send(new GetProfileQuery(
                authId,
                profileId,
                username
            ), cancellationToken);

        return profiles.Match(
            response => Ok(_mapper.Map<ProfileResponse>(response)),
            Problem<ProfileResponse>
        );
    }

    [HttpGet]
    public async Task<ActionResult<MyProfilesResponse>> GetMyProfiles(CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();

        var profiles = await _sender
            .Send(new GetMyProfilesQuery(authId), cancellationToken);

        return profiles.Match(
            response => Ok(_mapper.Map<MyProfilesResponse>(response)),
            Problem<MyProfilesResponse>
        );
    }

    [HttpPut("{profileId:guid}/promote")]
    public async Task<ActionResult<ProfileResponse>> PromoteProfileToAccount(Guid profileId, [FromBody] PromoteProfileRequest request, CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();

        var profiles = await _sender
            .Send(new PromoteProfileToAccountCommand(
                authId,
                profileId,
                request.Email,
                request.Password
            ), cancellationToken);

        return profiles.Match(
            response => Ok(_mapper.Map<ProfileResponse>(response)),
            Problem<ProfileResponse>
        );
    }

    [HttpDelete("{profileId:guid}")]
    public async Task<ActionResult<ProfileResponse>> DeletePNestedProfile(Guid profileId, CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();

        var profiles = await _sender
            .Send(new DeleteNestedProfileCommand(
                authId,
                profileId
            ), cancellationToken);

        return profiles.Match(
            response => Ok(_mapper.Map<ProfileResponse>(response)),
            Problem<ProfileResponse>
        );
    }

    [HttpPost]
    public async Task<ActionResult<ProfileResponse>> CreateNestedProfile([FromForm] CreateNestedProfileRequest request, CancellationToken cancellation = default)
    {
        var authId = HttpContext.User.GetUserId();

        var addNestedProfile = await _sender
            .Send(new CreateNestedProfileCommand(
                    authId,
                    request.Name,
                    request.BornDate,
                    request.Gender,
                    request.UserName,
                    request.PictureStream
                ), cancellation);

        return addNestedProfile.Match(
            response => Ok(_mapper.Map<ProfileResponse>(response)),
            Problem<ProfileResponse>
        );
    }

    [HttpPut()]
    public async Task<ActionResult<ProfileResponse>> UpdateProfile(
        [FromForm] UpdateProfileRequest request,
        [FromQuery] Guid profileId,
        CancellationToken cancellationToken = default)
    {
        var authId = HttpContext.User.GetUserId();

        var addNestedProfile = await _sender
            .Send(new UpdateProfileCommand(
                authId,
                profileId,
                request.Username,
                request.Email,
                request.Phone,
                request.PhoneCode,
                request.PictureStream
            ), cancellationToken);

        return addNestedProfile.Match(
            response => Ok(_mapper.Map<ProfileResponse>(response)),
            Problem<ProfileResponse>
        );
    }
}