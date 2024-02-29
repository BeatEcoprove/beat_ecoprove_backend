using System.Diagnostics.CodeAnalysis;

using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Shared;

public interface IApplicationDbContext
{
    DbSet<Auth> Auths { get; }
    DbSet<Profile> Profiles { get; }
    DbSet<Cloth> Cloths { get; }
    DbSet<Bucket> Buckets { get; }
    DbSet<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>() where TEntity : class;
    string? GetConnectionString();
}