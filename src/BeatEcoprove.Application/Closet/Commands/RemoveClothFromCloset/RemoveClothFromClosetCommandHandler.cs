using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RemoveClothFromCloset;

public class RemoveClothFromClosetCommandHandler : ICommandHandler<RemoveClothFromClosetCommand, ErrorOr<ClothResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveClothFromClosetCommandHandler(
        IProfileManager profileManager, 
        IClosetService closetService, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<ClothResult>> Handle(RemoveClothFromClosetCommand request, CancellationToken cancellationToken)
    {
        var clothId = ClothId.Create(request.ClothId);
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var cloth = await _closetService.RemoveClothFromCloset(profile.Value, clothId, cancellationToken);

        if (cloth.IsError)
        {
            return cloth.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return cloth;
    }
}