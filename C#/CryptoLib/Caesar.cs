using System.Text.RegularExpressions;

namespace CryptoLib
{
    public static class Caesar
    {
        public static string Encrypt(string input, int shift)
        {
            if (!Regex.IsMatch(input, @"^[a-zA-Z ]+$"))
            {
                return "Error: Only letters A-Z are allowed";
            }

            char[] buffer = input.Replace(" ", "").ToUpper().ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                if (letter > 'Z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'A')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        public static string Decrypt(string input, int shift)
        {
            if (!Regex.IsMatch(input, @"^[a-zA-Z ]+$"))
            {
                return "Error: Only letters A-Z are allowed";
            }

            char[] buffer = input.Replace(" ", "").ToUpper().ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter - shift);
                if (letter > 'Z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'A')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
