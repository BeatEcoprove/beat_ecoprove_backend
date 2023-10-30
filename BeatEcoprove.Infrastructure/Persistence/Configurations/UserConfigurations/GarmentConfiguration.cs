using BeatEcoprove.Domain;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure;

public class GarmentConfiguration : IEntityTypeConfiguration<Garment>
{
    public void Configure(EntityTypeBuilder<Garment> builder)
    {
        builder.ToTable("garments");
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Id)
            .HasColumnName("id")
            .HasConversion(
                gId => gId.Value,
                gId => GarmentId.Create(gId));

        builder.Property(g => g.Profile)
            .HasColumnName("profile")
            .HasConversion(
                profileId => profileId.Value,
                profileId => ProfileId.Create(profileId));

        builder.Property(g => g.Name)
            .HasColumnName("name")
            .IsRequired();

        builder.Property(g => g.Type)
            .HasColumnName("type")
            .IsRequired();

        builder.Property(g => g.Size)
            .HasColumnName("size")
            .IsRequired();

        builder.Property(g => g.Brand)
            .HasColumnName("brand")
            .IsRequired();

        builder.Property(g => g.Color)
            .HasColumnName("color")
            .IsRequired();

        builder.Property(g => g.IsBlocked)
            .HasColumnName("is_blocked")
            .IsRequired();

        builder.Property(g => g.Ecscore)
            .HasColumnName("ecscore")
            .IsRequired();

        builder.Property(g => g.ClothAvatar)
            .HasColumnName("cloth_avatar")
            .IsRequired();
    }
}
