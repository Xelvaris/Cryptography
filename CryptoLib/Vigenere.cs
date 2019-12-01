using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLib
{
    public static class Vigenere
    {
        public static string Run(string inputText, string keyword, int mode)
        { 
            List<char> alphabet =
                Enumerable.Range('a', 'z' - 'a' + 1)
                .Select(x => (char)x).ToList();

            char[][] tabulaRecta = new char['z' - 'a' + 1][];
            for (int i = 0; i < tabulaRecta.Length; i++)
            {
                tabulaRecta[i] = alphabet.ToArray();
                var first = alphabet.First();
                alphabet.Remove(first);
                alphabet.Insert(alphabet.Count, first);
            }

            if(mode == 1)
            {
                string cipherText = Encrypt(inputText, tabulaRecta, keyword);
                return cipherText;
            }
            else if(mode == 2)
            {
                string decipherText = Decrypt(inputText, tabulaRecta, keyword);
            }
            return "Error: Invalid mode";  
        }

        private static string GrowToTextSize(int length, string keyword)
        {
            string result = keyword;

            int idx = 0;
            while (result.Length < length)
            {
                result += keyword[idx++];

                if (idx >= length)
                {
                    idx = 0;
                }
            }

            return result;
        }

        private static char[][] TransposeMatrix(char[][] matrix)
        {
            char[][] result = new char[matrix[0].Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new char[matrix.Length];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    result[col][row] = matrix[row][col];
                }
            }

            return result;
        }

        private static int IndexOf(char[] array, char toFind)
        {
            int result = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == toFind)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        private static string Encrypt(
            string clearText, char[][] tabulaRecta, string keyword)
        {
            string result = string.Empty;

            keyword = GrowToTextSize(clearText.Length, keyword);

            for (int i = 0; i < clearText.Length; i++)
            {
                int row = clearText[i] - 'a';
                int col = keyword[i] - 'a';

                result += tabulaRecta[row][col];
            }

            return result;
        }

        private static string Decrypt(
            string cipherText, char[][] tabulaRecta, string keyword)
        {
            string result = string.Empty;

            keyword = GrowToTextSize(cipherText.Length, keyword);
            tabulaRecta = TransposeMatrix(tabulaRecta);

            for (int i = 0; i < cipherText.Length; i++)
            {
                int row = keyword[i] - 'a';
                int col = IndexOf(tabulaRecta[row], cipherText[i]);

                result += tabulaRecta[0][col];
            }

            return result;
        }
    }
}
