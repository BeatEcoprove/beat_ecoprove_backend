﻿using BeatEcoprove.Domain.UserAggregator;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Application.Interfaces.Persistence.Repositories;

public interface IUserRepository : IRepository<User, UserId>
{
    Task<bool> ExistsUserByEmailAsync(Email email, CancellationToken cancellationToken = default);
}