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
        return default;
    }
    
    public bool Equals(Enumeration<TEnum> other)
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
}