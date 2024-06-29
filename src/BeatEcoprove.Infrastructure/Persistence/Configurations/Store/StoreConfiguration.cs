using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Store;

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
        
        builder.Property(s => s.Rating)
            .HasColumnName("rating")
            .IsRequired();
        
        builder.Property(s => s.Picture)
            .HasColumnName("picture")
            .IsRequired();
        
        builder.Property(s => s.Level)
            .HasColumnName("level")
            .IsRequired();
        
        builder.Property(s => s.Localization)
            .HasColumnName("localization")
            .IsRequired();
        
        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(s => s.Owner)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Property(cloth => cloth.DeletedAt)
            .HasColumnName("deleted_at");
    }
}