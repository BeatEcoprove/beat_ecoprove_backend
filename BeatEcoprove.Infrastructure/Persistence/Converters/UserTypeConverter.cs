﻿using System.Linq.Expressions;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeatEcoprove.Infrastructure;

public class UserTypeConverter : ValueConverter<UserType, int>
{
    public UserTypeConverter() : base(
            v => v,
            v => (UserType)v)
    { }
}
