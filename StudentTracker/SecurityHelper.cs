using System;
using System.Text;
using System.Security.Cryptography;

namespace StudentTracker
{
    public static class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
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
