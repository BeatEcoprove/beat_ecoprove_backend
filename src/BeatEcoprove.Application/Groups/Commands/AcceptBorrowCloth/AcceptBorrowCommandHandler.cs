using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

using MongoDB.Bson;

using MessageId = BeatEcoprove.Domain.GroupAggregator.ValueObjects.MessageId;

namespace BeatEcoprove.Application.Groups.Commands.AcceptBorrowCloth;

internal sealed class AcceptBorrowCommandHandler : ICommandHandler<AcceptBorrowCommand, ErrorOr<string>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IMessageRepository _messageRepository;
    private readonly IClothRepository _clothRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AcceptBorrowCommandHandler(
        IProfileManager profileManager,
        IGroupRepository groupService,
        IMessageRepository messageRepository,
        IClothRepository clothRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _groupRepository = groupService;
        _messageRepository = messageRepository;
        _clothRepository = clothRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<string>> Handle(AcceptBorrowCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var messageId = MessageId.Create(ObjectId.Parse(request.MessageId));

        // get my profile
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        // get the message, check if i'm on group to get the message
        var message = await _messageRepository.GetByIdAsync(messageId, cancellationToken);

        if (message == null || message is not BorrowMessage borrowMessage)
        {
            return Errors.Groups.NotFound;
        }

        // get the actual cloth
        var groupId = GroupId.Create(borrowMessage.Group);
        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);

        if (group == null)
        {
            return Errors.Groups.NotFound;
        }

        if (!await _groupRepository.IsMemberAsync(groupId, profile.Value.Id, cancellationToken))
        {
            return Errors.Groups.CannotAccess;
        }

        var member = group.GetMemberByProfileId(profile.Value.Id);

        if (member == null)
        {
            return Errors.Groups.MemberNotFound;
        }

        if (message.Sender == member.Id)
        {
            return Errors.Profile.CannotExchageWithYourSelf;
        }

        // change the cloth of owner, that will be pretty
        var clothId = ClothId.Create(borrowMessage.ClothId);
        var cloth = await _clothRepository.GetByIdAsync(clothId, cancellationToken);

        if (cloth == null)
        {
            return Errors.Cloth.ClothNotFound;
        }

        if (cloth.State != ClothState.Blocked)
        {
            return Errors.Cloth.ClothIdBlocked;
        }

        // Switch Cloth from account
        await _clothRepository.RemoveByIdAsync(clothId, cancellationToken);

        var switchCloth = Cloth.Create(
            cloth.Name,
            cloth.Type,
            cloth.Size,
            cloth.Brand,
            cloth.Color
        );
        switchCloth.Value.SetClothPicture(cloth.ClothAvatar);
        profile.Value.AddCloth(switchCloth.Value);

        if (switchCloth.IsError)
        {
            return switchCloth.Errors;
        }

        await _clothRepository.AddAsync(switchCloth.Value, cancellationToken);

        // Update message of group saying that isn't more available
        borrowMessage.Accept();
        await _messageRepository.UpdateByIdAsync(messageId, borrowMessage, cancellationToken);

        // persist
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return request.MessageId;
    }
}