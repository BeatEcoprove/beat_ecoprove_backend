using BeatEcoprove.Application.Groups.Queries.GetGroupMessages;
using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
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

    public GetGroupMessageResultsQueryHandler(
        IProfileManager profileManager,
        IGroupRepository groupRepository,
        IMessageRepository messageRepository)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _messageRepository = messageRepository;
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

                return new MessageResult(
                    message.Group,
                    profile.Value,
                    message.Title,
                    message.CreatedAt
                );
            }).ToList();
    }
}