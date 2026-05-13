using System;
using System.Text;
using System.Security.Cryptography;

namespace StudentTracker
{
    public static class SecurityHelper
    {
        public static long GenerateRandomSalt()
        {
            long min = 100_000_000_000;
            long max = long.MaxValue;
            Random random = new Random();
            return min + (long)(random.NextDouble() * (max - min));
        }

        public static string HashPassword(string password, long salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string saltPassword = password + salt.ToString();
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltPassword));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    // Превращение в 16-ю строку
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
