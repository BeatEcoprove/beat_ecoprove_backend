using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Maintenance;

public class MaintenanceActionConfiguration : IEntityTypeConfiguration<MaintenanceAction>
{
    private const string MaintenanceActionTableName = "maintenance_service_actions";
    
    public void Configure(EntityTypeBuilder<MaintenanceAction> builder)
    {
        builder.ToTable(MaintenanceActionTableName);
        builder.HasKey(maintenanceAction => maintenanceAction.Id);
        
        builder.Property(ms => ms.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => MaintenanceActionId.Create(value));

        builder.Property(ms => ms.MaintenanceService)
            .HasColumnName("maintenance_service_id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => MaintenanceServiceId.Create(value));
        
        builder.Property(ms => ms.SustainablePoints)
            .HasColumnName("sustainable_points")
            .IsRequired();
        
        builder.Property(ms => ms.Title)
            .HasColumnName("title")
            .HasMaxLength(30)
            .IsRequired();
        
        builder.Property(ms => ms.Badge)    
            .HasColumnName("badge")
            .IsRequired();
        
        builder.Property(ms => ms.DeletedAt)
            .HasColumnName("deleted_at");
    }
}