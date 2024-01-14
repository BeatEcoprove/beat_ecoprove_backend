using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Maintenance;

public class MaintenanceConfiguration : IEntityTypeConfiguration<MaintenanceActivity>
{
    private const string MaintenanceActivityTableName = "maintenance_activities";
    
    public void Configure(EntityTypeBuilder<MaintenanceActivity> builder)
    {
        builder.ToTable(MaintenanceActivityTableName);
        
        // builder.HasMany(maintenance => maintenance.MaintenanceServices)
        //     .WithOne()
        //     .HasForeignKey(maintenanceService => maintenanceService.MaintenanceActivityId);
        
        builder.Property(ma => ma.ServiceId)
            .HasColumnName("service_id")
            .IsRequired()
            .HasConversion(
                id => id.Value,
                value => MaintenanceServiceId.Create(value));
        
        builder.HasOne<MaintenanceService>()
            .WithMany()
            .HasForeignKey(ms => ms.ServiceId);
        
        builder.Property(ma => ma.ActionId) 
            .HasColumnName("action_id")
            .IsRequired()
            .HasConversion(
                id => id.Value,
                value => MaintenanceActionId.Create(value));
        
        builder.HasOne<MaintenanceAction>()
            .WithMany()
            .HasForeignKey(ma => ma.ActionId);
        
        builder.Property(ma => ma.SustainablePoints)
            .HasColumnName("sustainable_points")
            .IsRequired();

        builder.Property(maintenance => maintenance.DeletedAt)
            .HasColumnName("deleted_at");
    }
}