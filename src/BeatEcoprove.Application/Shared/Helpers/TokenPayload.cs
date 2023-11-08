using System.Globalization;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Helpers;

public abstract class TokenPayload
{
    protected TokenPayload(Tokens type)
    {
        Type = type;
    }

    protected TokenPayload(DateTime exp, Tokens type)
    {
        ExpireAt = exp;
        Type = type;
    }

    public Tokens Type { get; set; }
    public DateTime ExpireAt { get; set; }

    public abstract IDictionary<string, string> GetPayload();
}