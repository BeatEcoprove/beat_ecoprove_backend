using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Converters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.ServiceProvider;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    private const string OrderTable = "store_orders";
    
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(OrderTable);
        builder.HasKey(order => order.Id);

        builder.Property(order => order.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                orderId => orderId.Value,
                value => OrderId.Create(value)
            )
            .IsRequired();

        builder.Property(order => order.Store)
            .HasColumnName("store")
            .ValueGeneratedNever()
            .HasConversion(
                storeId => storeId.Value,
                value => StoreId.Create(value)
            )
            .IsRequired();

        builder.Property(order => order.Owner)
            .HasColumnName("owner")
            .ValueGeneratedNever()
            .HasConversion(
                ownerId => ownerId.Value,
                value => ProfileId.Create(value)
            )
            .IsRequired();

        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(order => order.Owner);

        builder.Property(order => order.AssignedWorker)
            .HasColumnName("assigned_worker")
            .ValueGeneratedNever()
            .HasConversion(
                assignedWorkerId => assignedWorkerId.Value,
                value => WorkerId.Create(value)
            ).IsRequired(required: false);

        builder.HasOne<Worker>()
            .WithMany()
            .HasForeignKey(order => order.AssignedWorker);

        builder.Property(order => order.Status)
            .HasColumnName("status")
            .IsRequired();

        builder.Property(order => order.AcceptedAt)
            .HasColumnName("accepted_at");
        
        builder.HasDiscriminator(u => u.Type)
            .HasValue<OrderCloth>(OrderType.Cloth)
             .HasValue<OrderBucket>(OrderType.Bucket);
        
        builder.Property(a => a.Type)
            .HasColumnName("type")
            .HasConversion(new OrderTypeConverter())
            .IsRequired();

        builder.HasMany(order => order.Services)
            .WithOne()
            .HasForeignKey(service => service.Order);

        builder.HasQueryFilter(b => b.Services.All(be => be.DeletedAt == null));

        builder.Property(order => order.DeletedAt)
            .HasColumnName("deleted_at");
    }
}