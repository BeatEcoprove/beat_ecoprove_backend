using BeatEcoprove.Domain.UserAggregator;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        ConfigureUserTable(builder);
    }

    private static void ConfigureUserTable(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("app_users");

        builder.HasDiscriminator(a => a.Type)
           .HasValue<Consumer>(UserType.Consumer)
           .HasValue<Organization>(UserType.Organization);

        builder.Property(a => a.Type)
            .HasColumnName("type")
            .HasConversion(new UserTypeConverter())
            .IsRequired();

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedNever()
            .HasColumnName("id")
            .HasConversion(
                u => u.Value,
                u => UserId.Create(u));

        builder.Property(u => u.Email)
            .HasColumnName("email")
            .IsRequired()
            .HasMaxLength(256)
            .HasConversion(
                e => e.Value,
                e => Email.Create(e).Value);

        builder.Property(u => u.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(u => u.Password)
            .HasColumnName("password")
            .IsRequired()
            .HasMaxLength(256)
            .HasConversion(
                p => p.Value,
                p => Password.Create(p).Value);

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

        builder.Property(u => u.AvatarUrl)
            .HasColumnName("avatar_url")
            .IsRequired()
            .HasMaxLength(256);
    }
}
