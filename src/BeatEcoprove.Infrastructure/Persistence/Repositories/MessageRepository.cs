using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class MessageRepository : DocumentRepository<Message, MessageId>, IMessageRepository
{
    public MessageRepository(IMongoDatabase database) : base(database)
    {
    }

    public async Task<List<Message>> GetMessagesAsync(
        GroupId groupId,
        int page,
        int pageSize,
        CancellationToken cancellationToken)
    {
        var filter = Builders<Message>
           .Filter
           .Eq("Group", groupId);

        return await Collection
            .Find(filter)
            .SortByDescending(x => x.CreatedAt)
            .Skip((page - 1) * pageSize)
            .Limit(pageSize)
            .ToListAsync(cancellationToken);
    }
}