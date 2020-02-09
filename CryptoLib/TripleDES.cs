using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoLib
{
    public class TripleDES
    {
        public static string Encrypt(string Input, string Key)
        {
            byte[] MyEncryptedArray = UTF8Encoding.UTF8.GetBytes(Input);

            var TripleDES = new TripleDESCryptoServiceProvider();

            TripleDES.Key = MD5.HashArray(Key);

            TripleDES.Mode = CipherMode.ECB;

            TripleDES.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = TripleDES.CreateEncryptor();

            byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(MyEncryptedArray, 0, MyEncryptedArray.Length);

            TripleDES.Clear();

            return Convert.ToBase64String(MyresultArray, 0, MyresultArray.Length);
        }



        public static string Decrypt(string Input, string Key)
        {
            byte[] MyDecryptArray = Convert.FromBase64String(Input);

            var TripleDES = new TripleDESCryptoServiceProvider();

            TripleDES.Key = MD5.HashArray(Key);

            TripleDES.Mode = CipherMode.ECB;

            TripleDES.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = TripleDES.CreateDecryptor();

            byte[] MyresultArray = MyCrytpoTransform.TransformFinalBlock(MyDecryptArray, 0, MyDecryptArray.Length);

            TripleDES.Clear();

            return UTF8Encoding.UTF8.GetString(MyresultArray);
        }
    }
}
