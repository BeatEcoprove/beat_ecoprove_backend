using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.ServiceProvider;

public class StoreConfiguration : IEntityTypeConfiguration<Domain.StoreAggregator.Store>
{
    private const string StoreTable = "stores";
    
    public void Configure(EntityTypeBuilder<Domain.StoreAggregator.Store> builder)
    {
        builder.ToTable(StoreTable);
        builder.HasKey(s => s.Id);
        
        builder.Property(store => store.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                storeId => storeId.Value,
                id => StoreId.Create(id)
            )
            .IsRequired();
        
        builder.Property(s=> s.Owner)
            .HasColumnName("owner")
            .ValueGeneratedNever()
            .HasConversion(
                groupId => groupId.Value,
                value => ProfileId.Create(value));
        
        builder.Property(s => s.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.OwnsOne(s => s.Address, address =>
            {
                address.Property(a => a.Street)
                    .HasColumnName("street")
                    .IsRequired()
                    .HasMaxLength(256);
        
                address.Property(a => a.Port)
                    .HasColumnName("port")
                    .IsRequired();
        
                address.Property(a => a.Locality)
                    .HasColumnName("locality")
                    .IsRequired()
                    .HasMaxLength(256);
        
                address.OwnsOne(a => a.PostalCode, pc =>
                {
                    pc.Property(pc => pc.Value)
                        .HasColumnName("postal_code")
                        .IsRequired()
                        .HasMaxLength(256);
                });
            }
        );
        
        builder.Property(s => s.SustainablePoints)
            .HasColumnName("sustainable_points")
            .IsRequired();

        builder.Ignore(rating => rating.TotalRate);
        
        builder.Property(s => s.Picture)
            .HasColumnName("picture")
            .IsRequired();
        
        builder.Property(s => s.Level)
            .HasColumnName("level")
            .IsRequired();
        
        builder.Property(s => s.Localization)
            .HasColumnName("localization")
            .HasColumnType("geography (point)")
            .IsRequired();
        
        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(s => s.Owner)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Property(cloth => cloth.DeletedAt)
            .HasColumnName("deleted_at");

        builder.HasMany(store => store.Workers)
            .WithOne()
            .HasForeignKey(worker => worker.Store);
        
        builder.HasQueryFilter(b => b.Workers.All(be => be.DeletedAt == null));
        
        builder.HasMany(store => store.Orders)
            .WithOne()
            .HasForeignKey(order => order.Store);        
        
        builder.HasQueryFilter(b => b.Orders.All(be => be.DeletedAt == null));

        builder.HasMany(order => order.Ratings)
            .WithOne()
            .HasForeignKey(order => order.Store);
        
        builder.HasQueryFilter(b => b.Ratings.All(be => be.DeletedAt == null));
    }
}