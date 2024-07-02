using System.Security.Cryptography;
using System.Text;

using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Infrastructure.Providers;

public class PasswordGenerator : IPasswordGenerator
{
    private const string PasswordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:,.<>?/~`";

    public Password GeneratePassword(int minPasswordLength, int maxPasswordLength)
    {
        if (minPasswordLength > maxPasswordLength || minPasswordLength < 1 || maxPasswordLength < 1)
        {
            throw new ArgumentException("Password length limits are not valid.");
        }

        using var rng = RandomNumberGenerator.Create();
        int length = RandomInt(rng, minPasswordLength, maxPasswordLength + 1);

        var password = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            int index = RandomInt(rng, 0, PasswordChars.Length);
            password.Append(PasswordChars[index]);
        }

        var output = Password.Create(password.ToString());
        return output.IsError ? GeneratePassword(minPasswordLength, maxPasswordLength) : output.Value;
    }

    private static int RandomInt(RandomNumberGenerator rng, int minValue, int maxValue)
    {
        if (minValue >= maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(minValue), "minValue must be less than maxValue");
        }

        long range = (long)maxValue - minValue;

        int bytesNeeded = (int)Math.Ceiling(Math.Log(range, 256));
        byte[] buffer = new byte[bytesNeeded];

        rng.GetBytes(buffer);

        long randomValue = buffer.Aggregate<byte, long>(0, (current, t) => (current << 8) | t);

        randomValue %= range;

        return (int)(minValue + randomValue);
    }}