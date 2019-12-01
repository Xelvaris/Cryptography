using System;

namespace CryptoLib
{
    class Affine
    {
        public static string Encrypt(string text, int a, int b)
        {
            string ciphertext = "";
            char[] chars = text.ToUpper().ToCharArray();

            foreach(char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                ciphertext += Convert.ToChar(((a * x + b) % 26) + 65);
            }
            return ciphertext;
        }

        public static string Decrypt(string text, int a, int b)
        {
            string plaintext = "";

            int aInvers = MultiplicativeInverse(a);

            char[] chars = text.ToUpper().ToCharArray();

            foreach(char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                if (x - b < 0)
                {
                    x += Convert.ToInt32(x) + 26;
                }
                plaintext += Convert.ToChar(((aInvers * (x - b)) % 26) + 65);
            }
            return plaintext;
        }

        public static int MultiplicativeInverse(int a)
        {
            for (int i = 1; i < 27; i++)
            {
                if ((a * i) % 26 == 1)
                {
                    return i;
                }
                throw new Exception("No Multiplicative Inverse Found");
            }
            return -1;
        }
    }
}
