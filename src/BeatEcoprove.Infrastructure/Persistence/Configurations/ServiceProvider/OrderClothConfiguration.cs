using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.ServiceProvider;

public class OrderClothConfiguration : IEntityTypeConfiguration<OrderCloth>
{
    public void Configure(EntityTypeBuilder<OrderCloth> builder)
    {
        builder.Property(orderCloth => orderCloth.Cloth)
            .HasColumnName("cloth")
            .ValueGeneratedNever()
            .HasConversion(
                clothId => clothId.Value,
                value => ClothId.Create(value)
            )
            .IsRequired();

        builder.HasOne<Cloth>()
            .WithMany()
            .HasForeignKey(orderCloth => orderCloth.Cloth);
    }
}