using System.Security.Cryptography;
using System.Text;

namespace CryptoLib
{
    public class SHA1
    {
        public static string Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA1CryptoServiceProvider SHA1CryptoService = new SHA1CryptoServiceProvider();
            byte[] bytes = SHA1CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2"));
            }
            SHA1CryptoService.Clear();
            return hash.ToString();
        }
        public static byte[] HashArray(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA1CryptoServiceProvider SHA1CryptoService = new SHA1CryptoServiceProvider();
            byte[] bytes = SHA1CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            SHA1CryptoService.Clear();
            return bytes;
        }
    }
}
