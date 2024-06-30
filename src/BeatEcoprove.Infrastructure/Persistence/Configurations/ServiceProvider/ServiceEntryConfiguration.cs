using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.ServiceProvider;

public class ServiceEntryConfiguration : IEntityTypeConfiguration<ServiceEntry>
{
    private const string ServiceEntriesTable = "orders_maintenance_services";
    
    public void Configure(EntityTypeBuilder<ServiceEntry> builder)
    {
        builder.ToTable(ServiceEntriesTable);
        builder.HasKey(entry => new { entry.Order, entry.Service });
        
        builder.Property(service => service.Order)
            .HasColumnName("order")
            .ValueGeneratedNever()
            .HasConversion(
                orderId => orderId.Value,
                value => OrderId.Create(value)
            )
            .IsRequired();
            
        builder.Property(service => service.Service)
            .HasColumnName("service")
            .ValueGeneratedNever()
            .HasConversion(
                serviceId => serviceId.Value,
                value => MaintenanceServiceId.Create(value)
            )
            .IsRequired();
        
        builder.HasOne<MaintenanceService>()
            .WithMany()
            .HasForeignKey(entry => entry.Service);        
        
        builder.Property(service => service.DeletedAt) 
            .HasColumnName("deleted_at");    
    }
}