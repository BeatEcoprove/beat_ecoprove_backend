using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure;

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable("profiles");
        builder.HasKey("Id");

        builder.Property(p => p.Id)
            .HasColumnName("id")
            .HasConversion(
                pId => pId.Value,
                pId => ProfileId.Create(pId));

        builder.Property(p => p.Consumer)
            .HasColumnName("consumer_id")
            .HasConversion(
                pId => pId.Value,
                pId => UserId.Create(pId));

        builder.Property(p => p.IsMainProfile)
           .HasColumnName("is_main_profile");

        builder.Property(u => u.UserName)
            .HasColumnName("username")
            .IsRequired()
            .HasConversion(
                username => username.Value,
                username => UserName.Create(username));

        builder.Property(profile => profile.Gender)
            .HasColumnName("gender")
            .IsRequired();

        builder.Property(profile => profile.Xp)
            .HasColumnName("xp")
            .IsRequired();

        builder.Property(profile => profile.BornDate)
            .HasColumnName("born_date")
            .IsRequired();

        builder.Property(profile => profile.SustainabilityPoints)
            .HasColumnName("sustainability_points")
            .IsRequired();

        builder.Property(profile => profile.EcoScore)
            .HasColumnName("eco_score")
            .IsRequired();

        builder.Property(profile => profile.AvatarUrl)
            .HasColumnName("avatar_url")
            .IsRequired();
    }
}
