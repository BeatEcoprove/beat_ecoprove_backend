using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Authentication;

public class AuthConfiguration : IEntityTypeConfiguration<Auth>
{
    private const string AuthTable = "auths";

    public void Configure(EntityTypeBuilder<Auth> builder)
    {
        builder.ToTable(AuthTable);
        builder.HasKey(a => a.Id);

        builder.Property(auth => auth.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => AuthId.Create(value));

        builder.Property(auth => auth.Email)
            .HasColumnName("email")
            .HasMaxLength(256)
            .HasConversion(
                email => email.Value,
                value => Email.Create(value).Value);

        builder.Property(auth => auth.Password)
            .HasColumnName("password")
            .HasMaxLength(256)
            .HasConversion(
                password => password.Value,
                value => Password.FromHash(value));

        builder.Property(auth => auth.Salt)
            .HasColumnName("salt");

        builder.Property(auth => auth.IsEnabled)
            .HasColumnName("is_enabled");

        builder.Property(auth => auth.MainProfileId)
            .HasColumnName("main_profile_id")
            .ValueGeneratedNever()
            .HasConversion(
                mainProfileId => mainProfileId.Value,
                value => ProfileId.Create(value)
                );
    }
}
