using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Domain.UserAggregator;
using BeatEcoprove.Domain.UserAggregator.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure;

public class BeatEcoproveDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=sa;Password=password;Database=ecoprove;");
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BeatEcoproveDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
