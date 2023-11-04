using System.Diagnostics.CodeAnalysis;
using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure;

public interface IApplicationDbContext
{
    DbSet<Auth> Auths { get; }
    DbSet<Profile> Profiles { get; }

    DbSet<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>() where TEntity : class;

}
