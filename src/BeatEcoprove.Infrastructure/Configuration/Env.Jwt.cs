using System.Security.Cryptography;

namespace BeatEcoprove.Infrastructure.Configuration;

public partial class Env
{
    public class Jwt
    {
        private readonly static string DefaultSecretKey = GenerateRandomSecretKey();
        private static string GenerateRandomSecretKey(int keyLength = 256)
        {
            using Aes aesAlgorithm = Aes.Create();
            aesAlgorithm.KeySize = keyLength;
            aesAlgorithm.GenerateKey();

            return Convert.ToBase64String(aesAlgorithm.Key);
        }

        public static string SecretKey => GetString("JWT_SECRET_KEY", DefaultSecretKey);
        public static string JwtIssuer => GetString("JWT_ISSUER", "https://localhost:5001");
        public static string JwtAudience => GetString("JWT_AUDIENCE", "https://localhost:5001");
        public static int JwtAccessTokenExpiration => GetInteger("JWT_ACCESS_TOKEN_EXPIRATION", 1);
        public static int JwtRefreshTokenExpiration => GetInteger("JWT_REFRESH_TOKEN_EXPIRATION", 2);
    }
}