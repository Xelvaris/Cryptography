using System.Collections.Generic;
using System.Linq;

namespace CryptoLib
{
    public static class Vigenere
    {
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private static string Cipher(string input, string key, bool encipher)
        {
            if (string.IsNullOrEmpty(key))
            {
                return "Error: You must enter a keyword";
            }
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                {
                    return "Error: Non-letter character entered in keyword";
                }

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        public static string Encrypt(string input, string key)
        {
            return Cipher(input, key, true);
        }

        public static string Decrypt(string input, string key)
        {
            return Cipher(input, key, false);
        }
        
    }
}
