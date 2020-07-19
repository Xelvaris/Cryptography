using System.Security.Cryptography;
using System.Text;

namespace CryptoLib
{
    public class MD5
    {
        public static string Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider MD5CryptoService = new MD5CryptoServiceProvider();
            byte[] bytes = MD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2"));
            }
            MD5CryptoService.Clear();
            return hash.ToString();
        }
        public static byte[] HashArray(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider MD5CryptoService = new MD5CryptoServiceProvider();
            byte[] bytes = MD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            MD5CryptoService.Clear();
            return bytes;
        }
    }
}
