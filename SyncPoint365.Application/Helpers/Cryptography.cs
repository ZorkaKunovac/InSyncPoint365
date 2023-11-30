using System.Text;
using System.Security.Cryptography;

namespace SyncPoint365.Application.Helpers
{
    public static class Cryptography
    {
        const int KeySize = 64;
        const int Iterations = 350000;

        public static string GenerateSalt()
        {
            var salt = RandomNumberGenerator.GetBytes(KeySize);

            return Convert.ToBase64String(salt);
        }

        public static string GenerateHash(string input, string salt)
        {
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(input),
                Encoding.UTF8.GetBytes(salt),
                Iterations,
                HashAlgorithmName.SHA512,
                KeySize);

            return Convert.ToHexString(hash);
        }
    }
}
