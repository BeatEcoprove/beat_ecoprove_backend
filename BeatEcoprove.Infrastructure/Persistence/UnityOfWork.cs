using BeatEcoprove.Application.Shared.Interfaces.Persistence;

namespace BeatEcoprove.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    // private readonly InvBankDbContext _dbContext;
    //
    // public UnitOfWork(InvBankDbContext invBankDbContext)
    // {
    //     _dbContext = invBankDbContext;
    // }

    public async  Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
         await Task.CompletedTask;
        // return _dbContext.SaveChangesAsync(cancellationToken);
    }
}