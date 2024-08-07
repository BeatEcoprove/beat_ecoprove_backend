﻿using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.Enumerators;

public class UserType : Enumeration<UserType>
{
    public static readonly UserType Consumer = new(0, typeof(Consumer));
    public static readonly UserType Organization = new(1, typeof(Organization));
    public static readonly UserType Employee = new(2, typeof(Employee));

    private UserType(int value, Type type)
        : base(value, type)
    {
    }

    public string GetUserType()
    {
        return Type.Name.ToLower();
    }

    public static explicit operator UserType(int v) => FromValue(v)!;

    public static explicit operator int(UserType v) => v.Value;
}