using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Profile;

public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder
           .Property(o => o.TypeOption)
           .HasColumnName("type_option")
           .IsRequired();

        builder.OwnsOne(o => o.Address, address =>
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
        });
    }
}