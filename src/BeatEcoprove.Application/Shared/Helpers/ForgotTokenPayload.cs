using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Helpers;

public class ForgotTokenPayload : TokenPayload
{
    private readonly string _email;

    public ForgotTokenPayload(string email, DateTime exp) : base(exp, Tokens.ForgotPassword)
    {
        _email = email;
    }

    public override IDictionary<string, string> GetPayload() =>
        new Dictionary<string, string>
        {
            { UserClaims.Email, _email }
        };
}