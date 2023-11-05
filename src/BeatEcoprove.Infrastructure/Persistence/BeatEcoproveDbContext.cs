using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence;

public class BeatEcoproveDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{

    public DbSet<Auth> Auths { get; set; } = null!;

    public DbSet<Profile> Profiles { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=sa;Password=password;Database=ecoprove;");
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BeatEcoproveDbContext).Assembly);
        // modelBuilder.ApplyConfiguration(new ProfileConfiguration());
        // modelBuilder.ApplyConfiguration(new ConsumerConfiguration());
        // modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
        // modelBuilder.ApplyConfiguration(new AuthConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
