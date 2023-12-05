using BeatEcoprove.Domain.ClosetAggregator.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class MaintenanceConfiguration : IEntityTypeConfiguration<MaintenanceActivity>
{
    private const string MaintenanceActivityTableName = "maintenance_activities";
    
    public void Configure(EntityTypeBuilder<MaintenanceActivity> builder)
    {
        builder.ToTable(MaintenanceActivityTableName);
        
        builder.HasMany(maintenance => maintenance.MaintenanceServices)
            .WithOne()
            .HasForeignKey(maintenanceService => maintenanceService.MaintenanceActivityId);
        
        builder.Property(maintenance => maintenance.Title)
            .HasColumnName("title")
            .HasMaxLength(30)
            .IsRequired();
        
        builder.Property(maintenance => maintenance.Badge)
            .HasColumnName("badge")
            .IsRequired();
        
        builder.Property(maintenance => maintenance.PointsOfSustentability)
            .HasColumnName("points_of_sustainability")
            .IsRequired();
    }
}