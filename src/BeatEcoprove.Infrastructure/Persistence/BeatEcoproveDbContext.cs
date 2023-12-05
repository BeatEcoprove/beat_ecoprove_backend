using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Infrastructure.Extensions;
using BeatEcoprove.Infrastructure.Persistence.Interceptors;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BeatEcoprove.Infrastructure.Persistence;

public class BeatEcoproveDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{
    private readonly DbSettings _dbSettings;
    private readonly SoftDeleteInterceptor _softDeleteInterceptor;
    
    public BeatEcoproveDbContext(
        IOptions<DbSettings> dbSettings, 
        SoftDeleteInterceptor softDeleteInterceptor)
    {
        _softDeleteInterceptor = softDeleteInterceptor;
        _dbSettings = dbSettings.Value;
    }

    public DbSet<Auth> Auths { get; set; } = null!;
    public DbSet<Profile> Profiles { get; set; } = null!;
    public DbSet<Cloth> Cloths { get; set; } = null!;
    public DbSet<Bucket> Buckets { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_softDeleteInterceptor);
        
        optionsBuilder.UseNpgsql(_dbSettings.ConnectionString, builder =>
        {
            builder.MigrationsAssembly("BeatEcoprove.Infrastructure");
        });
        
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(BeatEcoproveDbContext).Assembly);
        
        modelBuilder
            .SetUpGlobalQueryFilters<ISoftDelete>((entity) => entity.DeletedAt == null);

        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
