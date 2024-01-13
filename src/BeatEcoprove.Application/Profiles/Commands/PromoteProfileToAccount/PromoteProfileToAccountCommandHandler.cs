using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.PromoteProfileToAccount;

internal sealed class PromoteProfileToAccountCommandHandler : ICommandHandler<PromoteProfileToAccountCommand, ErrorOr<Profile>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAccountService _accountService;
    private readonly IUnitOfWork _unitOfWork;
    
    public PromoteProfileToAccountCommandHandler(
        IProfileManager profileManager, 
        IAccountService accountService, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _accountService = accountService;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<ErrorOr<Profile>> Handle(PromoteProfileToAccountCommand request, CancellationToken cancellationToken)
    {
        var authId = request.AuthId;
        var profileId = request.ProfileId;
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);

        var validationResult = email.AddValidate(password);
        
        if (validationResult.IsError)
        {
            return validationResult.Errors;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var result = await _accountService.CreateAccountFromProfile(
            email.Value,
            password.Value,
            profile.Value,
            cancellationToken: cancellationToken
        );
        
        if (result.IsError)
        {
            return result.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return profile;
    }
}