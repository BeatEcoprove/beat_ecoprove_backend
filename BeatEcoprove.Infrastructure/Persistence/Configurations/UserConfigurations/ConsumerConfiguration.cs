using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeatEcoprove.Infrastructure;

public class ConsumerConfiguration : IEntityTypeConfiguration<Consumer>
{
    public void Configure(EntityTypeBuilder<Consumer> builder)
    {
        builder.HasMany(c => c.Profiles)
           .WithOne()
           .HasForeignKey(p => p.Consumer)
           .IsRequired(false);

        builder.Metadata.FindNavigation(nameof(Consumer.Profiles))!.SetPropertyAccessMode(PropertyAccessMode.Field);
        builder.Ignore(c => c.MainProfile);
        // builder.HasOne<Profile>()
        //     .WithMany()
        //     .HasForeignKey("MainProfile")
        //     .IsRequired(false);
    }
}
