using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IMessageRepository : IRepository<Message, MessageId>
{
    Task<List<Message>> GetMessagesAsync(GroupId groupId, int page, int pageSize, CancellationToken cancellationToken);
}
