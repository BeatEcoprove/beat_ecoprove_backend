using BeatEcoprove.Application.Groups.Queries.GetGroupMessages;
using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Communication.ChatMessage;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupMessageResults;

internal sealed class GetGroupMessageResultsQueryHandler : IQueryHandler<GetGroupMessagesQuery, ErrorOr<List<MessageResult>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IMessageRepository _messageRepository;
    private readonly IClosetService _clothRepository;

    public GetGroupMessageResultsQueryHandler(
        IProfileManager profileManager,
        IGroupRepository groupRepository,
        IMessageRepository messageRepository,
        IClosetService clothRepository)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _messageRepository = messageRepository;
        _clothRepository = clothRepository;
    }

    public async Task<ErrorOr<List<MessageResult>>> Handle(GetGroupMessagesQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var groupId = GroupId.Create(request.GroupId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        if (!await _groupRepository.IsMemberAsync(groupId, profile.Value.Id, cancellationToken))
        {
            return Errors.Groups.MemberNotFound;
        }

        var messages = await _messageRepository.GetMessagesAsync(
            groupId,
            request.Page,
            request.PageSize,
            cancellationToken);

        var senderIds = messages
            .Select(message => message.Sender)
            .ToList();

        var profiles = await _groupRepository
            .GetMemberProfiles(groupId, senderIds, cancellationToken);

        return messages
            .Select((message) =>
            {
                var profile = profiles
                    .SingleOrDefault(p => p.Key == message.Sender);

                if (message is BorrowMessage)
                {
                    BorrowMessage borrowMessage = (BorrowMessage)message;
                    var cloth = _clothRepository.GetClothResult(profile.Value, ClothId.Create(borrowMessage.ClothId)).GetAwaiter().GetResult();

                    if (cloth.IsError)
                    {
                        return new MessageResult(
                             message.Group,
                             profile.Value,
                             message.Title,
                             message.CreatedAt
                         );
                    }

                    return new BorrowMessageResult(
                                        message.Group,
                                        profile.Value,
                                        message.Title,
                                        message.CreatedAt,
                                        new BorrowClothResponse(
                                            cloth.Value.ClothAvatar,
                                            cloth.Value.Name,
                                            cloth.Value.Brand,
                                            cloth.Value.Color,
                                            cloth.Value.Size,
                                            cloth.Value.EcoScore.ToString()
                                        )
                                    );
                }


                return new MessageResult(
                    message.Group,
                    profile.Value,
                    message.Title,
                    message.CreatedAt
                );

            }).ToList();
    }
}