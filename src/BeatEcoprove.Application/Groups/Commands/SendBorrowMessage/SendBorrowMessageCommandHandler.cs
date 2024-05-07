using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Communication.ChatMessage;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.SendBorrowMessage;

internal sealed class SendBorrowMessageCommandHandler : ICommandHandler<SendBorrowMessageCommand, ErrorOr<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISessionManager _sessionManager;
    private readonly IGroupSessionManager _groupSessionManager;
    private readonly IProfileRepository _profileRepository;
    private readonly IGroupRepository _groupRepository;
    private readonly IClosetService _closetService;
    private readonly IClothRepository _clothRepository;

    public SendBorrowMessageCommandHandler(
        IUnitOfWork unitOfWork,
        ISessionManager sessionManager,
        IGroupSessionManager groupSessionManager,
        IProfileRepository profileRepository,
        IGroupRepository groupRepository,
        IClosetService closetService,
        IClothRepository clothRepository)
    {
        _unitOfWork = unitOfWork;
        _sessionManager = sessionManager;
        _groupSessionManager = groupSessionManager;
        _profileRepository = profileRepository;
        _groupRepository = groupRepository;
        _closetService = closetService;
        _clothRepository = clothRepository;
    }

    public async Task<ErrorOr<bool>> Handle(SendBorrowMessageCommand request, CancellationToken cancellationToken)
    {
        var userId = ProfileId.Create(request.UserId);
        var groupId = GroupId.Create(request.GroupId);
        var clothId = ClothId.Create(request.ClothId);

        if (!_sessionManager.IsUserAuthenticated(userId))
        {
            return Errors.Auth.InvalidAuth;
        }

        var groupSocket = _groupSessionManager.Get(groupId);

        if (groupSocket is null)
        {
            return Errors.Groups.WSNotFound;
        }

        if (!_groupSessionManager.IsUserMemberOfAnyGroup(userId))
        {
            return Errors.Groups.WSIsntConnected;
        }

        var profile = await _profileRepository.GetByIdAsync(userId, cancellationToken);

        if (profile is null)
        {
            return Errors.Profile.NotFound;
        }

        var cloth = await _closetService.GetClothResult(profile, clothId, cancellationToken: cancellationToken);

        if (cloth.IsError)
        {
            return cloth.Errors;
        }

        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);

        if (group is null)
        {
            return Errors.Groups.WSNotFound;
        }

        var borrowMessage = group.AddBorrowMessage(profile, request.Message, clothId);

        if (borrowMessage.IsError)
        {
            return borrowMessage.Errors;
        }

        var shouldBlockCloth = await _clothRepository.ChangeClothState(clothId, ClothState.Blocked, cancellationToken);

        if (!shouldBlockCloth)
        {
            return Errors.Cloth.ClothNotFound;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await _groupSessionManager.SendEveryoneAsync(
            groupId,
            new ChatMessageNotificationEvent<BorrowClothMessage>(
                userId,
                new BorrowClothMessage(
                    borrowMessage.Value.Id.Value.ToString(),
                    request.Message,
                    groupId,
                    new ChatMessageMember(
                        profile.Id,
                        profile.UserName,
                        profile.AvatarUrl
                    ),
                    new BorrowClothResponse(
                        cloth.Value.ClothAvatar,
                        cloth.Value.Name,
                        cloth.Value.Brand,
                        cloth.Value.Color,
                        cloth.Value.Size,
                        cloth.Value.EcoScore.ToString()
                    )
                ),
                nameof(BorrowClothMessage)
            )
        );

        return true;
    }
}