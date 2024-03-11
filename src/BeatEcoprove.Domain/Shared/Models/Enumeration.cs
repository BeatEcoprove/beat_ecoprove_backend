using System.Reflection;

namespace BeatEcoprove.Domain.Shared.Models;

public abstract class Enumeration<TEnum> : IEquatable<Enumeration<TEnum>>
    where TEnum : Enumeration<TEnum>
{
    private static readonly Dictionary<int, TEnum> Enumerations = CreateEnumerations();

    protected Enumeration(int value, Type type)
    {
        Value = value;
        Type = type;
    }

    public Type Type { get; protected init; }
    public int Value { get; protected init; }

    public static TEnum? FromType(Type type)
    {
        return default;
    }

    public static TEnum? FromValue(int value)
    {
        return Enumerations.TryGetValue(
            value,
            out TEnum? enumeration) ? enumeration : default;
    }

    public bool Equals(Enumeration<TEnum>? other)
    {
        if (other is null)
        {
            return false;
        }

        return Type == other.Type && Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        return obj is Enumeration<TEnum> other && Equals(other);
    }

    private static Dictionary<int, TEnum> CreateEnumerations()
    {
        var enumerationType = typeof(TEnum);

        var fields =
            enumerationType
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Where(field => enumerationType.IsAssignableFrom(field.FieldType))
                .Select(field => (TEnum)field.GetValue(default)!);

        return fields.ToDictionary(field => field.Value);
    }

    public static implicit operator int(Enumeration<TEnum> type) => type.Value;

    public override int GetHashCode()
    {
        return this.Value.GetHashCode();
    }
}


public abstract class Enumeration<TEnum, TType> : IEquatable<Enumeration<TEnum, TType>>
    where TEnum : Enumeration<TEnum, TType> where TType : notnull
{
    protected static readonly Dictionary<TType, TEnum> Enumerations = CreateEnumerations();

    protected Enumeration(TType value, Type type)
    {
        Value = value;
        Type = type;
    }

    public Type Type { get; protected init; }
    public TType Value { get; protected init; }

    public static TEnum? FromValue(TType value)
    {
        return Enumerations.GetValueOrDefault(value);
    }

    public bool Equals(Enumeration<TEnum, TType>? other)
    {
        if (other is null)
        {
            return false;
        }

        return Type == other.Type;
    }

    public override bool Equals(object? obj)
    {
        return obj is Enumeration<TEnum, TType> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Type, Value);
    }

    private static Dictionary<TType, TEnum> CreateEnumerations()
    {
        var enumerationType = typeof(TEnum);

        var fields =
            enumerationType
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Where(field => enumerationType.IsAssignableFrom(field.FieldType))
                .Select(field => (TEnum)field.GetValue(default)!);

        return fields.ToDictionary(field => field.Value);
    }
}