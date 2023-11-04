using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Profiles;

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    private const string TableName = "profiles";

    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable(TableName);
        builder.HasKey(profile => profile.Id);

        builder.Property(profile => profile.Id)
          .HasColumnName("Id")
          .ValueGeneratedNever()
          .HasConversion(
              id => id.Value,
              value => ProfileId.Create(value));

        builder.HasOne<Auth>()
            .WithMany()
            .HasForeignKey(t => t.AuthId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(profile => profile.AuthId)
            .HasColumnName("AuthId")
            .HasConversion(
                authId => authId.Value,
                value => AuthId.Create(value));

        builder.HasDiscriminator(u => u.Type)
           .HasValue<Consumer>(UserType.Consumer)
           .HasValue<Organization>(UserType.Organization);

        builder.Property(a => a.Type)
             .HasColumnName("type")
             .HasConversion(new UserTypeConverter())
             .IsRequired();

        builder.Property(profile => profile.UserName)
            .HasColumnName("user_name")
            .HasMaxLength(256)
            .HasConversion(
                userName => userName.Value,
                value => UserName.Create(value));

        builder.OwnsOne(u => u.Phone, p =>
        {
            p.Property(pp => pp.Code)
                .HasColumnName("phone_country_code")
                .IsRequired()
                .HasMaxLength(4);

            p.Property(pp => pp.Value)
                .HasColumnName("phone")
                .IsRequired()
                .HasMaxLength(256);
        });

        builder.Property(profile => profile.XP)
            .HasColumnName("xp");

        builder.Property(profile => profile.SustainabilityPoints)
            .HasColumnName("sustainability_points");

        builder.Property(profile => profile.EcoScore)
            .HasColumnName("eco_score");

        builder.Property(profile => profile.AvatarUrl)
            .HasColumnName("avatar_url")
            .HasMaxLength(256);
    }
}
