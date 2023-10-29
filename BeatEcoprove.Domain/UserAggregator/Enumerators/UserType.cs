using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.UserAggregator.Entities;

namespace BeatEcoprove.Domain.UserAggregator.Enumerators;

public class UserType : Enumeration<UserType>
{
    public static readonly UserType Consumer = new(0, typeof(Consumer));
    public static readonly UserType Organization = new(1, typeof(Organization));

    private UserType(int value, Type type)
        : base(value, type)
    {
    }

    public static explicit operator UserType(int v) => FromValue(v)!;

    public static explicit operator int(UserType v) => v.Value;
}