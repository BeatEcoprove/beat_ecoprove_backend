using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class MaintenanceServiceConfiguration : IEntityTypeConfiguration<MaintenanceService>
{
    private const string MaintenanceServiceTableName = "maintenance_services";
    
    public void Configure(EntityTypeBuilder<MaintenanceService> builder)
    {
        builder.ToTable(MaintenanceServiceTableName);
        builder.HasKey(maintenanceService => maintenanceService.Id);
        
        // builder.HasOne<MaintenanceActivity>()
        //     .WithMany()
        //     .HasForeignKey(a => a.MaintenanceActivityId);
        
        builder.Property(maintenanceService => maintenanceService.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => MaintenanceServiceId.Create(value));
        
        builder.Property(maintenanceService => maintenanceService.DeletedAt)
            .HasColumnName("deleted_at");
        
        builder.Property(maintenanceService => maintenanceService.MaintenanceActivityId)
            .HasColumnName("maintenance_activity_id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ActivityId.Create(value));
        
        builder.Property(maintenanceService => maintenanceService.Title)
            .HasColumnName("title")
            .HasMaxLength(30)
            .IsRequired();
        
        builder.Property(maintenanceService => maintenanceService.Description)
            .HasColumnName("description")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(maintenanceService => maintenanceService.Badge)
            .HasColumnName("badge")
            .IsRequired();
    }
}