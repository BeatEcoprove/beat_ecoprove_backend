using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.DeleteAccount;

internal sealed class DeleteAccountCommandHandler : ICommandHandler<DeleteAccountCommand, ErrorOr<AuthId>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAccountService _accountService;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteAccountCommandHandler(
        IProfileManager profileManager, 
        IAccountService accountService, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _accountService = accountService;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<AuthId>> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return Errors.Profile.NotFound;
        }
        
        var shouldDeleteAccount = await _accountService.DeleteAccount(authId, profileId, cancellationToken);

        if (shouldDeleteAccount.IsError)
        {
            return shouldDeleteAccount.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return authId;
    }
}