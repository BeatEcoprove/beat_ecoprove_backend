using System.Text.RegularExpressions;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.ClosetAggregator;

public class Color : AggregateRoot<ColorId, Guid>
{
    private const string HexRegex = "^#(?:[0-9a-fA-F]{3}){1,2}$";
    
    private Color(string name, string hex)
    {
        Name = name;
        Hex = hex;
    }
    
    private Color(string hex)
    {
        Hex = hex;
        Name = default!;
    }
    
    public string Name { get; private set; }
    public string Hex { get; private set; }
    
    private static bool IsValidHex(string hex)
    {
        return Regex.IsMatch(hex, HexRegex);
    }

    public static ErrorOr<Color> Create(string name, string hex)
    {
        if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(hex))
        {
            return Errors.Color.MustProvideColor;
        }
        
        if (!IsValidHex(hex))
        {
            return Errors.Color.BadHexValue;
        }
        
        return new Color(name, hex);
    }
    
    public static ErrorOr<Color> FromHex(string hex)
    {
        if (string.IsNullOrEmpty(hex))
        {
            return Errors.Color.MustProvideColor;
        }
        
        if (!IsValidHex(hex))
        {
            return Errors.Color.BadHexValue;
        }
        
        return new Color(hex);
    }
}