using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using BeatEcoprove.Application.Shared.Notifications;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.SendTextMessage;

internal sealed class SendTextMessageCommandHandler : ICommandHandler<SendTextMessageCommand, ErrorOr<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISessionManager _sessionManager;
    private readonly IGroupSessionManager _groupSessionManager;
    private readonly IProfileRepository _profileRepository;
    private readonly IGroupRepository _groupRepository;

    public SendTextMessageCommandHandler(
        IUnitOfWork unitOfWork,
        ISessionManager sessionManager,
        IProfileRepository profileRepository,
        IGroupRepository groupRepository,
        IGroupSessionManager groupSessionManager)
    {
        _unitOfWork = unitOfWork;
        _sessionManager = sessionManager;
        _profileRepository = profileRepository;
        _groupRepository = groupRepository;
        _groupSessionManager = groupSessionManager;
    }

    public async Task<ErrorOr<bool>> Handle(SendTextMessageCommand request, CancellationToken cancellationToken)
    {
        var userId = ProfileId.Create(request.UserId);
        var groupId = GroupId.Create(request.GroupId);
        
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

        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);

        if (group is null)
        {
            return Errors.Groups.WSNotFound;
        }

        var shouldAddMessage = group.AddTextMessage(profile, request.Message);

        if (shouldAddMessage.IsError)
        {
            return shouldAddMessage.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await _groupSessionManager.SendEveryoneAsync(
            groupId,
            new ChatTextMessage
            (
                groupId,
                profile.UserName,
                profile.AvatarUrl,
                request.Message
            ),
            cancellationToken
        );

        return true;
    }
}
