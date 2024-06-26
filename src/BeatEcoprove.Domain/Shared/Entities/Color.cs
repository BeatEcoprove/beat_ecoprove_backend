﻿using System.Text.RegularExpressions;

using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.Shared.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Entities;

public class Color : Entity<ColorId>
{
    private const string HexRegex = "^FF(?:[0-9a-fA-F]{3}){1,2}$";

    private Color() { }

    private Color(ColorId colorId, string name, string hex)
    {
        Id = colorId;
        Name = name;
        Hex = hex;
    }

    private Color(ColorId colorId, string hex)
    {
        Id = colorId;
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
            return Errors.Errors.Color.MustProvideColor;
        }

        if (!IsValidHex(hex))
        {
            return Errors.Errors.Color.BadHexValue;
        }

        return new Color(
            ColorId.CreateUnique(),
            name,
            hex
        );
    }

    public static ErrorOr<Color> FromHex(string hex)
    {
        if (string.IsNullOrEmpty(hex))
        {
            return Errors.Errors.Color.MustProvideColor;
        }

        if (!IsValidHex(hex))
        {
            return Errors.Errors.Color.BadHexValue;
        }

        return new Color(
            ColorId.CreateUnique(),
            hex
        );
    }

    public static implicit operator string(Color color) => color.Hex;
}