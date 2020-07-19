using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoLib
{
    public class DES
    {
        public static string Encrypt(string Input, string Key)
        {
            byte[] EncryptedArray = UTF8Encoding.UTF8.GetBytes(Input);

            var DES = new DESCryptoServiceProvider();

            DES.Key = MD5.HashArray(Key);

            DES.Mode = CipherMode.ECB;

            DES.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = DES.CreateEncryptor();

            byte[] ResultArray = MyCrytpoTransform.TransformFinalBlock(EncryptedArray, 0, EncryptedArray.Length);

            DES.Clear();

            return Convert.ToBase64String(ResultArray, 0, ResultArray.Length);
        }



        public static string Decrypt(string Input, string Key)
        {
            byte[] DecryptArray = Convert.FromBase64String(Input);

            var DES = new DESCryptoServiceProvider();

            DES.Key = MD5.HashArray(Key);

            DES.Mode = CipherMode.ECB;

            DES.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = DES.CreateDecryptor();

            byte[] ResultArray = MyCrytpoTransform.TransformFinalBlock(DecryptArray, 0, DecryptArray.Length);

            DES.Clear();

            return UTF8Encoding.UTF8.GetString(ResultArray);
        }
    }
}
