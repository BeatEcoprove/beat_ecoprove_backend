using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Infrastructure.Authentication;
using BeatEcoprove.Infrastructure.Profiles;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure;

public class BeatEcoproveDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{

    public DbSet<Auth> Auths { get; set; }

    public DbSet<Profile> Profiles { get; set; }

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
