using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.GroupAggregator;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BeatEcoprove.Infrastructure.Persistence.Interceptors;

public class StoreGroupInterceptor : SaveChangesInterceptor
{
    private readonly IMessageRepository _messageRepository;

    public StoreGroupInterceptor(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        StoreGroupProxy(eventData.Context).GetAwaiter().GetResult();
        return base.SavingChanges(eventData, result);
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await StoreGroupProxy(eventData.Context);
        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private async Task StoreGroupProxy(DbContext? dbContext, CancellationToken cancellationToken = default)
    {
        if (dbContext is null)
        {
            return;
        }

        var groupEntity = dbContext.ChangeTracker.Entries<Group>()
            .SingleOrDefault();

        if (groupEntity is null)
        {
            return;
        }

        var messages = groupEntity
            .Entity
            .Messages;

        if (messages.Count() == 0)
        {
            return;
        }

        var lastMessageSent = messages.Last();

        if (lastMessageSent is null)
        {
            return;
        }

        await _messageRepository
            .AddAsync(lastMessageSent, cancellationToken);
    }
}