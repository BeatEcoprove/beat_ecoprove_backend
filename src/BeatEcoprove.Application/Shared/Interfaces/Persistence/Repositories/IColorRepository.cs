﻿using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IColorRepository : IRepository<Color, ColorId>
{
    Task<List<Color>> GetAllColors(CancellationToken cancellationToken = default);
    Task<ColorId?> GetByHexValueAsync(string hexValue, CancellationToken cancellationToken = default);
}