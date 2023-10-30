using BeatEcoprove.Domain.UserAggregator;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
}
