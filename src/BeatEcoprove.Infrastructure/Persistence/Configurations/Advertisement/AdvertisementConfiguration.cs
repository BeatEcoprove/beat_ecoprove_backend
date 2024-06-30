using BeatEcoprove.Domain.AdvertisementAggregator.Entities;
using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Converters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Advertisement;

public class AdvertisementConfiguration : IEntityTypeConfiguration<Domain.AdvertisementAggregator.Advertisement>
{
    private const string AdvertisementTable = "advertisements";
    
    public void Configure(EntityTypeBuilder<Domain.AdvertisementAggregator.Advertisement> builder)
    {
        builder.ToTable(AdvertisementTable);
        builder.HasKey(add => add.Id);

        builder.Property(add => add.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                addId => addId.Value,
                value => AdvertisementId.Create(value)
            ).IsRequired();

        builder.Property(add => add.Creator)
            .HasColumnName("creator")
            .ValueGeneratedNever()
            .HasConversion(
                creatorId => creatorId.Value,
                value => ProfileId.Create(value)
            ).IsRequired();

        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(add => add.Creator);

        builder.Property(add => add.Title)
            .HasColumnName("title")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(add => add.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsRequired();

        builder.Property(add => add.InitDate)
            .HasColumnName("init_date")
            .IsRequired();

        builder.Property(add => add.EndDate)
            .HasColumnName("end_date")
            .IsRequired();

        builder.Property(add => add.Picture)
            .HasColumnName("picture")
            .IsRequired();

        builder.Property(add => add.SustainablePoints)
            .HasColumnName("sustainable_points")
            .IsRequired();

        builder.HasDiscriminator(u => u.Type)
            .HasValue<Domain.AdvertisementAggregator.Advertisement>(AdvertisementType.Advertisement)
            .HasValue<Voucher>(AdvertisementType.Voucher)
            .HasValue<Promotion>(AdvertisementType.Promotion);
        
        builder.Property(a => a.Type)
            .HasColumnName("type")
            .HasConversion(new AdvertisementTypeConverter())
            .IsRequired();
    }
}