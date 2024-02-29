using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Profile;

public class ConsumerConfiguration : IEntityTypeConfiguration<Consumer>
{
    public void Configure(EntityTypeBuilder<Consumer> builder)
    {
        builder.Property(profile => profile.BornDate)
            .HasColumnName("born_date")
            .IsRequired();

        builder.Property(profile => profile.Gender)
            .HasColumnName("gender")
            .IsRequired();
    }
}