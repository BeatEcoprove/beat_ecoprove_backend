using BeatEcoprove.Domain.AdvertisementAggregator.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Advertisement;

public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
{
    public void Configure(EntityTypeBuilder<Voucher> builder)
    {
        builder.Property(voucher => voucher.Quantity)
            .HasColumnName("quantity")
            .IsRequired();
    }
}