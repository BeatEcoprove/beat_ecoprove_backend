using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Profiles.Commands.CreateNestedProfile;
using BeatEcoprove.Application.Profiles.Commands.DeleteNestedProfile;
using BeatEcoprove.Application.Profiles.Commands.PromoteProfileToAccount;
using BeatEcoprove.Application.Profiles.Queries.GetMyProfiles;
using BeatEcoprove.Contracts.Profile;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("profiles")]
public class ProfileController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;
    
    public ProfileController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
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
}