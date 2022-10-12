using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCypher.Helper
{
    public static class CriptographyHelper
    {
        /// <summary>
        /// Método que chama a encriptação para cada letra.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Encrypt(string plainText)
        {
            var encrypted = string.Empty;
            foreach(char c in plainText)
            {
                encrypted += EncryptAlgorithm(c);
            }

            return encrypted;
        }

        /// <summary>
        /// Método que chama a decriptação para cada letra.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Decrypt(string encryptedText)
        {
            var decrypted = string.Empty;
            foreach (char c in encryptedText)
            {
                decrypted += DecryptAlgorithm(c);
            }

            return decrypted;
        }

        /// <summary>
        /// Método que aplica a encriptação de César em um letra utilizando índice 3.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static char EncryptAlgorithm(char c)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }

            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + 3) - d) % 26) + d);
        }

        /// <summary>
        /// Método que aplica a decriptação de César em um letra utilizando índice 3.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static char DecryptAlgorithm(char c)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }

            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + 23) - d) % 26) + d);
        }
    }
}
