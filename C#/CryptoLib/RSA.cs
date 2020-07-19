using System;
using System.Security.Cryptography;

/*Usage Code examples
 * UnicodeEncoding ByteConverter = new UnicodeEncoding();  
 * RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();  
 * byte[] plaintext;  
 * byte[] encryptedtext;
 * 
 * --Button click encrypt
 * plaintext = ByteConverter.GetBytes(txtplain.Text);  
 * encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);  
 * txtencrypt.Text = ByteConverter.GetString(encryptedtext);  
 * 
 * --Button click dencrypt
 * byte[] decryptedtex = Decryption(encryptedtext,   
 * RSA.ExportParameters(true), false);  
 * txtdecrypt.Text = ByteConverter.GetString(decryptedtex); 
 */

namespace CryptoLib
{
    public class RSA
    {
        public static byte[] Encrypt(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static byte[] Decrypt(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
